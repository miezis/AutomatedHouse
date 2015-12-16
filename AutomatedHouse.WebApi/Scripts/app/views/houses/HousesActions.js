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

	createHouse(payload) {
		const params = {
			Name: payload.name,
			ApiKey: payload.apiKey
		};

		http.post('/houses', params)
			.then((response) => {
				if (response.statusCode === 200) {
					this.dispatch();
					return this.actions.getHouses();
				}
			});
	}

	updateHouse(payload) {
		const params = {
			Name: payload.name,
			ApiKey: payload.apiKey
		};

		http.put('/houses', params)
			.then((response) => {
				if (response.statusCode === 200) {
					this.dispatch();
					return this.action.getHouses();
				}
			});
	}

	toggleCreateMode() {
		this.dispatch();
	}
}
 
export default app.createActions(HousesActions);