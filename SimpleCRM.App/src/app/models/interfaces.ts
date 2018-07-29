export interface IItem {
  id: number;
  active: boolean;
  dCreate: Date;
}

export interface IContact extends IItem {
  lastName: string;
  firstName: string;
}

export interface ICompany extends IItem {
  name: string;
}

export interface IAction extends IItem {
  name: string;
}
