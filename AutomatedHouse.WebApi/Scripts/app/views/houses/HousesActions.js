import app from '../../App';
import http from '../../utils/http';
 
class HousesActions {
	getHouses() {
		http.get('/house')
			.then((response) => {
				if (response.statusCode === 200) {
					this.dispatch(response.body);
				}
			});
	}

	updateHouse() {
		this.dispatch({ name: 'Random House' });
	}
}
 
export default app.createActions(HousesActions);