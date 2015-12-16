import app from '../../App';
import http from '../../utils/http';
 
class HousesActions {
	getHouses() {
		http.get('/houses')
			.then((response) => {
				if (response.statusCode === 200) {
					this.dispatch(response.body);
				}
			});
	}
}
 
export default app.createActions(HousesActions);