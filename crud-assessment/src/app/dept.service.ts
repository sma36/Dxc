import { Injectable } from '@angular/core';
import { department } from "./dept";

@Injectable({
  providedIn: 'root'
})
export class DeptService {

  constructor() { }
  deptlist:department[]=[
    {id:1,name:'Engineering',groupName:'Research and Development',date:new Date('01-06-2002')},
    {id:2,name:'Tool Design',groupName:'Research and Development',date:new Date('07-08-2002')},
    {id:3,name:'Sales',groupName:'Sales and Marketing',date:new Date('01-06-2002')},
    {id:4,name:'Marketing',groupName:'Sales and Marketing',date:new Date('07-08-2002')}
  ];

  sendlist(){
    return this.deptlist
  }
  save(p:department){
    this.deptlist.push(p)
  }
  del(i){
    this.deptlist.splice(i,1)
  }

}
