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

  gotRooms(rooms) {
    this.setState({rooms});
  }
}
 
export default app.createStore(RoomsStore, 'RoomsStore');