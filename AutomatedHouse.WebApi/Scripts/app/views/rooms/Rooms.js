import _ from 'lodash';
import react from 'react';
import DocumentTitle from 'react-document-title';
import connectToStores from 'alt/utils/connectToStores';

import RoomsActions from './RoomsActions';
import RoomsStore from './RoomsStore';

import Accessories from './Accessories';
import Sensors from './Sensors';

@connectToStores
class Rooms extends react.Component {
  constructor(props) {
    super(props);

    RoomsActions.getRooms(props.params.id);
  }
 
  render() {
    const props = this.props;

    return (
      <div>
        <DocumentTitle title="Rooms"/>
        <div className="row">{this.renderRooms(props.rooms)}</div>
      </div>
    );
  }

  renderRooms(rooms) {
    if (!rooms.length) {
      return null;
    }

    return _.map(rooms, (room) => (
      <div>
        <div className="col-xs-12" key={room.Id}>
          <div className="panel panel-default">
            <div className="panel-heading">
              <h3 className="panel-title">{room.Name}</h3>
            </div>
            <div className="panel-body">
              <Accessories />
              <Sensors />
            </div>
          </div>
        </div>
      </div>
    ));
  }

  static getStores(props) {
    return [RoomsStore];
  }

  static getPropsFromStores(props) {
    return RoomsStore.getState();
  }
}

export default Rooms;