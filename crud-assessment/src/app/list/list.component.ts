import { Component, OnInit } from '@angular/core';
import { department } from "./../dept";
import { DeptService } from "./../dept.service";

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {
  dlist:department[]
  flag=false
  d:department

  constructor(private ds:DeptService) { }

  ngOnInit() {
    this.dlist=this.ds.sendlist()
  }

  update(i){
    this.flag=true
    this.d=this.ds.deptlist[i]
  }
  done(){
    this.d.date=new Date()
    this.flag=false
  }
  delete(i){
  this.ds.del(i)
  }

}
