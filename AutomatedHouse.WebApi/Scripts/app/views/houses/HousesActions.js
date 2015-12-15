import app from '../../App';
 
class HousesActions {
  updateHouse() {
  	return { name: 'Random House' };
  	//this.dispatch({ name: 'Random House' });
  }
}
 
export default app.createActions(HousesActions);