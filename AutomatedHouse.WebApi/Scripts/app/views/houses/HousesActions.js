import app from '../../App';
 
class HousesActions {
  updateHouse() {
  	this.dispatch({ name: 'Random House' });
  }
}
 
export default app.createActions(HousesActions);