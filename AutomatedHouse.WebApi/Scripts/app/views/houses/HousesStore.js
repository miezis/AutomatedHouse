import app from '../../App';
import HousesActions from './HousesActions';
 
class HousesStore {
  constructor() {
    this.bindListeners({
      updateHouse: HousesActions.UPDATE_HOUSE
    });
 
    this.state = {
      house: {
        name: 'Primary House'
      }
    };
  }
 
  updateHouse(house) {
    this.setState({ house: house });
  }
}
 
export default app.createStore(HousesStore, 'HousesStore');