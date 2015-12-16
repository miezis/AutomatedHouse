import _ from 'lodash';
import react from 'react';
import DocumentTitle from 'react-document-title';
import connectToStores from 'alt/utils/connectToStores';


import HouseActions from './HousesActions';
import HousesStore from './HousesStore';

import HouseForm from './HouseForm';


@connectToStores
class Houses extends react.Component {
  constructor(props) {
    super(props);

    HouseActions.getHouses();
  }
 
  render() {
    const props = this.props;

    return (
      <div>
        <DocumentTitle title="My Houses" />
        <button className="btn btn-default" onClick={this.activateCreateMode.bind(this)}>{props.createModeActivated ? 'Cancel' : 'Create New House'}</button>
        {props.createModeActivated && <HouseForm onSubmit={this.createHouse.bind(this)} />}
        <div className="row">{this.renderHouses(props.houses)}</div>
      </div>
    );
  }

  renderHouses(houses) {
    if (!houses.length) {
      return null;
    }

    return _.map(houses, (house) => (
        <div className="col-xs-4" key={house.Id}>
          <div className="panel panel-default">
            <div className="panel-heading">
              <h3 className="panel-title">{house.Name}</h3>
            </div>
            <div className="panel-body">
              <p>API Key: {house.ApiKey ? house.ApiKey : 'Not Defined'}</p>
            </div>
          </div>
        </div>
      ));
  }

  activateCreateMode() {
    HouseActions.toggleCreateMode();
  }

  createHouse(payload) {
    HouseActions.createHouse(payload);
  }

  updateHouse(payload) {
    HouseActions.updateHouse(payload);
  }

  static getStores(props) {
    return [HousesStore];
  }

  static getPropsFromStores(props) {
    return HousesStore.getState();
  }
}

export default Houses;