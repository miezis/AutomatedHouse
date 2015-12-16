import when from 'when';
import app from '../../App';
import http from '../../utils/http';
 
class RoomsActions {
	getRooms(houseId) {
		const requests = [
			http.get(`/rooms/${houseId}`),
			http.get(`/sensors/${houseId}`)
		];

		return when.all(requests)
			.then((responses) => {
				const [rooms, sensors] = responses
				if (rooms.statusCode === 200 && sensors.statusCode === 200) {
					this.dispatch({
						rooms: rooms.body,
						sensors: sensors.body
					});
				}
			});
	}
}
 
export default app.createActions(RoomsActions);