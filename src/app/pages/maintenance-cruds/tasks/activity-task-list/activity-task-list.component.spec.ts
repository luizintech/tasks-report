import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ActivityTaskListComponent } from './activity-task-list.component';

describe('ActivityTaskListComponent', () => {
  let component: ActivityTaskListComponent;
  let fixture: ComponentFixture<ActivityTaskListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ActivityTaskListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ActivityTaskListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
