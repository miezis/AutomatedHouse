import _ from 'lodash';
import react from 'react';
import DocumentTitle from 'react-document-title';
import connectToStores from 'alt/utils/connectToStores';


import HouseActions from './HousesActions';
import HousesStore from './HousesStore';


@connectToStores
class Houses extends react.Component {
  constructor(props) {
    super(props);
    HouseActions.getHouses();
  }

  static getStores(props) {
    return [HousesStore];
  }

  static getPropsFromStores(props) {
    return HousesStore.getState();
  }
 
  render() {
    return (
      <div>
        <DocumentTitle title="Dashboard::Houses" />
        {this.renderHouses(this.props.houses)}
      </div>
    );
  }

  renderHouses(houses) {
    if (!houses.length) {
      return null;
    }

    return _.map(houses, (house) => (
        <div className="house-card" key={house.Id}>
          <p>Name: {house.Name}</p>
          <p>Rooms: {house.rooms ? house.Rooms.length : 0}</p>
        </div>
      ));
  }
}

export default Houses;