export class PaymentDetail{
    public paymentDetailId?: number|null;

    constructor(paymentDetailId: number,
    public cardOwnerName: string='',
    public cardNumber: string='',
    public expirationDate?: Date,
    public securityCode: string=''
    ){
        this.paymentDetailId = paymentDetailId ? paymentDetailId : null;
    }
}