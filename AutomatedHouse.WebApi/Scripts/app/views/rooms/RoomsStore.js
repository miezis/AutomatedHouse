import app from '../../App';
import RoomsActions from './RoomsActions';
 
class RoomsStore {
  constructor() {
    this.bindListeners({
      gotRooms: RoomsActions.GET_ROOMS
    });
 
    this.state = {
      rooms: [],
      sensors: []
    };
  }

  gotRooms(payload) {
    this.setState(payload);
  }
}
 
export default app.createStore(RoomsStore, 'RoomsStore');