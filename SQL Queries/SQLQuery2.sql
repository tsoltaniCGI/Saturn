select contact_person_id, address_line_1, city, state_province_code, name AS 'Grower Name', producer_id, full_name AS 'Vendor Name' 
from s1_contact_person, s1_name_and_address, s1_producer
where s1_producer.producer_id = s1_name_and_address.name_and_address_id
and s1_contact_person.name_and_address_id = s1_name_and_address.name_and_address_id
and s1_contact_person.name <> s1_name_and_address.full_name
order by producer_id, contact_person_id

select * from SATURN_DEV.saturndba.growers_temp


select producer_id, full_name AS 'Vendor Name', address_line_1, city, state_province_code
from s1_name_and_address, s1_producer
where s1_producer.producer_id = s1_name_and_address.name_and_address_id
order by producer_id
delete from relationships
delete from growers
insert into SATURN_DEV.saturndba.relationships (grower_id, vendor_id)
values 

insert into SATURN_DEV.saturndba.relationships (grower_id, vendor_id)
values (1, '10001' )
select @@identity from SATURN_DEV.saturndba.relationships

insert into SATURN_DEV.saturndba.vendors
(vendor_id, vendor_name, vendor_address_line_1, vendor_address_line_2,
vendor_city, vendor_country, vendor_county, vendor_state, vendor_zip,
vendor_email)
SELECT vendor_id, vendor_name, vendor_address_line_1, vendor_address_line_2,
vendor_city, vendor_country, vendor_county, vendor_state, vendor_zip,
vendor_email FROM SATURN_DEV.saturndba.vendors_temp
WHERE vendor_id = '10001'

select * from SATURN_DEV.saturndba.growers_temp

select * from SATURN_DEV.saturndba.relationships
delete from SATURN_DEV.saturndba.relationships where grower_id = 1
delete from growers_temp

select * from vendors_temp where vendor_id = '10030'
Delete from relationships_temp
Delete from growers_temp
select * from relationships_temp
select * from growers_temp order by grower_id

insert into SATURN_DEV.saturndba.growers
(grower_first_name, grower_last_name, grower_address_line_1, grower_address_line_2,
grower_city, grower_country, grower_county, grower_created_by, grower_date_created,
grower_email, grower_phone1, grower_phone2, grower_state, grower_zip)
select grower_first_name, grower_last_name, grower_address_line_1, grower_address_line_2,
grower_city, grower_country, grower_county, grower_created_by, grower_date_created,
grower_email, grower_phone1, grower_phone2, grower_state, grower_zip
from SATURN_DEV.saturndba.growers_temp where grower_id = 2
select @@IDEN
select * from SATURN_DEV.saturndba.growers

select * from s1_name_and_address

create table relationships_temp   -- the relationship of an grower to a farm entity, e.g.  The Jones Farm relates to Mr Jones, Mrs Jones, master Jones, miss Jones
(
grower_id 	integer not null,
vendor_id 	integer not null
)
select vendor_customer_id, full_name, plc_id, plc_flag
from s1_contract, s1_producer, s1_name_and_address
where s1_name_and_address.name_and_address_id = s1_producer.producer_id
and s1_contract.vendor_customer_id = s1_producer.producer_id
order by plc_flag DESC


select name_and_address_id
from s1_name_and_address
where plc_flag = 'Y'

select name_and_address_id
from s1_name_and_address, s1_producer
where s1_producer.producer_id = s1_name_and_address.name_and_address_id

delete from vendors_facilities

select vendor_name, facility_name, facilities.facility_id
from vendors, facilities, vendors_facilities
where facilities.facility_id = vendors_facilities.facility_id
and vendors.vendor_id = vendors_facilities.vendor_id
and facility_name = 'Wilma'

select * from users

insert into users (user_first_name, user_last_name, user_login, user_job_title, user_role, User_facility_id)
values ('Amanda', 'Tester', 'ATESTER', 'Chief Testing Officer', 1, 119)

select growers.grower_id, vendors.vendor_id, grower_first_name, grower_address_line_1, grower_city, grower_county, grower_state, grower_zip, grower_country, grower_phone1, vendor_name, commodity_name
from growers, growers_vendors, vendors, vendors_facilities, users, commodities, vendors_commodities
where user_id = 339
and vendors_facilities.facility_id = User_facility_id
and vendors.vendor_id = vendors_facilities.vendor_id
and growers_vendors.grower_id = growers.grower_id
and vendors.vendor_id = growers_vendors.vendor_id
and commodities.commodity_id = vendors_commodities.commodity_id
and vendors.vendor_id = vendors_commodities.vendor_id
order by growers.grower_id, vendors.vendor_id, commodity_name



select * from vendors_commodities




delete from vendors_facilities

select * from vendors_commodities

select * from vendors_facilities

select * from vendors_facilities order by facility_id
select * from facilities

SELECT DISTINCT AGTECH_DBCT.dbo.s1_contract.commodity_id, SATURN_DEV.saturndba.vendors.vendor_id
FROM AGTECH_DBCT.dbo.s1_name_and_address, AGTECH_DBCT.dbo.s1_producer, AGTECH_DBCT.dbo.s1_contract, SATURN_DEV.saturndba.vendors
WHERE AGTECH_DBCT.dbo.s1_producer.producer_id = AGTECH_DBCT.dbo.s1_name_and_address.name_and_address_id
and AGTECH_DBCT.dbo.s1_contract.vendor_customer_id = AGTECH_DBCT.dbo.s1_name_and_address.name_and_address_id
and SATURN_DEV.saturndba.vendors.agtech_vendor_id = AGTECH_DBCT.dbo.s1_name_and_address.name_and_address_id


SELECT DISTINCT SATURN_DEV.saturndba.vendors.vendor_id, SATURN_DEV.saturndba.facilities.facility_id
FROM AGTECH_DBCT.dbo.s1_name_and_address, AGTECH_DBCT.dbo.s1_producer, AGTECH_DBCT.dbo.s1_contract, SATURN_DEV.saturndba.vendors, SATURN_DEV.saturndba.facilities
WHERE AGTECH_DBCT.dbo.s1_producer.producer_id = AGTECH_DBCT.dbo.s1_name_and_address.name_and_address_id
and AGTECH_DBCT.dbo.s1_contract.vendor_customer_id = AGTECH_DBCT.dbo.s1_name_and_address.name_and_address_id
and SATURN_DEV.saturndba.vendors.agtech_vendor_id = AGTECH_DBCT.dbo.s1_name_and_address.name_and_address_id
and SATURN_DEV.saturndba.facilities.agtech_facility_id = AGTECH_DBCT.dbo.s1_contract.plc_id

select * from SATURN_DEV.saturndba.vendors
select * from vendors
select DISTINCT vendor_customer_id, plc_id
from s1_contract
where contract_
