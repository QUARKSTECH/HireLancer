import { ProServiceStatus } from '../enum/pro-service-status.enum';

export class ProService {
  name: string;
  iconPath: string;
  description: string;
  rating: string;
  price: number;
  status: ProServiceStatus;
}
