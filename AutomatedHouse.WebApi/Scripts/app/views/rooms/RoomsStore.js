import _ from 'lodash';
import app from '../../App';
import RoomsActions from './RoomsActions';
 
class RoomsStore {
  constructor() {
    this.bindListeners({
      gotRooms: RoomsActions.GET_ROOMS
    });
 
    this.state = {
      rooms: []
    };
  }

  gotRooms(payload) {
    const rooms = transformData(payload);

    this.setState({rooms});
  }
}

function transformData(payload) {
  const rooms = payload.rooms;
  const sensors = payload.sensors;
  const accessories = payload.accessories;

  _.each(rooms, (room) => {
    room.accessories = _(accessories)
                        .filter({RoomId: room.Id})
                        .map((acc) => _.omit(acc, ['RoomId', 'Room', 'HouseId', 'House']))
                        .value();

    room.sensors = _(sensors)
                        .filter({RoomId: room.Id})
                        .map((sen) => _.omit(sen, ['RoomId', 'Room', 'HouseId', 'House']))
                        .value();
  });

  return rooms;
}

export default app.createStore(RoomsStore, 'RoomsStore');