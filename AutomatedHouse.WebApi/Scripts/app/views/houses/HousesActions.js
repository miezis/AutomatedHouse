import app from '../../App';
import http from '../../utils/http';
 
class HousesActions {
	getHouses() {
		http.get('/house')
			.then((response) => {
				if (!!response) {
					this.dispatch(response);
				}
			});
	}

	updateHouse() {
		this.dispatch({ name: 'Random House' });
	}
}
 
export default app.createActions(HousesActions);