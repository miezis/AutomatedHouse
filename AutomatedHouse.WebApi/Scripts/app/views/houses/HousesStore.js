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

/*class LocationStore {
  constructor() {
    this.locations = [];

    this.bindListeners({
      handleUpdateLocations: LocationActions.UPDATE_LOCATIONS
    });
  }

  handleUpdateLocations(locations) {
    this.locations = locations;
  }
}*/