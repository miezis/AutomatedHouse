import app from '../../App';
import HousesActions from './HousesActions';
 
class HousesStore {
  constructor() {
    this.bindListeners({
      getHouses: HousesActions.GET_HOUSES
    });
 
    this.state = {
      houses: []
    };
  }

  getHouses(houses) {
    this.setState({houses});
  }
}
 
export default app.createStore(HousesStore, 'HousesStore');