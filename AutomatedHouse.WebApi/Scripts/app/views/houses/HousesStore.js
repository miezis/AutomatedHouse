import app from '../../App';
import HousesActions from './HousesActions';
 
class HousesStore {
  constructor() {
    this.bindListeners({
      getHouses: HousesActions.GET_HOUSES,
      toggleCreateMode: HousesActions.TOGGLE_CREATE_MODE,
      houseUpdated: HousesActions.UPDATE_HOUSE,
      houseCreated: HousesActions.CREATE_HOUSE
    });
 
    this.state = {
      houses: [],
      createModeActivated: false
    };
  }

  getHouses(houses) {
    this.setState({houses});
  }

  houseUpdated() {
    this.toggleCreateMode();
  }

  houseCreated() {
    this.toggleCreateMode();
  }

  toggleCreateMode() {
    const createModeActivated = !this.state.createModeActivated;

    this.setState({createModeActivated});
  }
}
 
export default app.createStore(HousesStore, 'HousesStore');