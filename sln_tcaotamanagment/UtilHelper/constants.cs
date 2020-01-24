using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace UtilHelper
{
    public class constants
    {
		IDictionary<string, string> dXpath = new Dictionary<string, string>() {
			{ "ResStatus "          , "/OTA_HotelResRQ" },
			{ "CreatorID"           , "/OTA_HotelResRQ/HotelReservations/HotelReservation/CreatorID" },
			{ "RoomStayReservation" , "/OTA_HotelResRQ/HotelReservations/HotelReservation/RoomStayReservation"},
			{ "ID_Context"          , "/OTA_HotelResRQ/HotelReservations/HotelReservation/UniqueID/ID_Context "},
			{ "ID_Context"          , "/OTA_HotelResRQ/HotelReservations/HotelReservation/ResGlobalInfo/Profiles/ProfileInfo/UniqueID"},
			{ "UniqueID"            , "/OTA_HotelResRQ/HotelReservations/HotelReservation/ResGlobalInfo/Profiles/ProfileInfo/UniqueID"},
			{ "RoomStayReservatio"  , "/OTA_HotelResRQ/HotelReservations/HotelReservation/RoomStayReservation"},
			{ "MarketCode"          , "/OTA_HotelResRQ/HotelReservations/HotelReservation/RoomStays/RoomStay/MarketCode"},
			{ "NumberOfUnits"       , "/OTA_HotelResRQ/HotelReservations/HotelReservation/RoomStays"},
			{ "RoomTypeCode"        , "/OTA_HotelResRQ/HotelReservations/HotelReservation/RoomStays/RoomStay/RoomTypes/RoomType"},
			{ "Name"                , ":/OTA_HotelResRQ/HotelReservations/HotelReservation/RoomStays/RoomStay/RoomTypes/RoomType/Room"},
			{ "RatePlanName"        , "OTA_HotelResRQ/HotelReservations/HotelReservation/RoomStays/RoomStay/RatePlans/RatePlan/RatePlanName"},
			{ "ExpireDate"          , "/OTA_HotelResRQ/HotelReservations/HotelReservation/RoomStays/RoomStay/RoomRates/RoomRate"},
			{ "RatePlanCode"        , "/OTA_HotelResRQ/HotelReservations/HotelReservation/RoomStays/RoomStay/RatePlans/RatePlan"},
			{ "RatePlanType"        , "/OTA_HotelResRQ/HotelReservations/HotelReservation/RoomStays/RoomStay/RatePlans/RatePlan"},
			{ "UnitMultiplier"      , "/OTA_HotelResRQ/HotelReservations/HotelReservation/RoomStays/RoomStay/RoomRates/RoomRate/Rates/Rate"},
			{ "AgeQualifyingCode"   , "/OTA_HotelResRQ/HotelReservations/HotelReservation/RoomStays/RoomStay/GuestCounts/GuestCount"},
			{ "End"                 , "/OTA_HotelAvailRQ/AvailRequestSegments/AvailRequestSegment/StayDateRange"},
			{ "Duration"            , "/OTA_HotelResRQ/HotelReservations/HotelReservation/RoomStay/TimeSpan"},
			{ "Start"               , "/OTA_HotelAvailRQ/AvailRequestSegments/AvailRequestSegment/StayDateRange"},
			{ "ProfileType"         , "/OTA_HotelAvailRQ/AvailRequestSegments/AvailRequestSegment/StayDateRange"},
			{ "PhoneNumber"         , "/OTA_HotelResRQ/HotelReservations/HotelReservation/ResGuests/ResGuest/Profiles/ProfileInfo/Profile/Customer/Telephone"},
			{ "CompanyShortName"    , "/OTA_HotelResRQ/HotelReservations/HotelReservation/ResGuests/ResGuest/Profiles/ProfileInfo/Profile/Affilia tions/TravelArranger"},
			{ "ResID_Type"          , "/OTA_HotelResRQ/HotelReservations/HotelReservation/ResGlobalInfo/HotelReservationIDs/HotelReservationID"},
			{ "ResID_Value"         , "/OTA_HotelResRQ/HotelReservations/HotelReservation/ResGlobalInfo/HotelReservationIDs/HotelReservationID"},
			{ "ResID_Source"        , "/OTA_HotelResRQ/HotelReservations/HotelReservation/ResGlobalInfo/HotelReservationIDs/HotelReservationID"},
			{ "ResID_SourceContext" , "/OTA_HotelResRQ/HotelReservations/HotelReservation/ResGlobalInfo/HotelReservationIDs/HotelReservationID"}
		};

		XmlDocument soapEnvelopeXml = new XmlDocument();
		public XmlDocument OTA_HotelResNotifRQ(string url, string action, Dictionary<string, string> parameters, string soapAction = null, bool useSOAP12 = false)
        {
            // Create the SOAP envelope
            XmlDocument soapEnvelopeXml = new XmlDocument();
            soapEnvelopeXml.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>
                                    <s:Envelope xmlns:s=""http://schemas.xmlsoap.org/soap/envelope/"">
                                    <s:Header>
                                        <h:HTNGHeader xmlns:h=""http://pms.tca-ss.com"" xmlns=""http://pms.tca-ss.com"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
                                            <From>
                                            </From>
                                            <To>
                                            </To>
                                            <TimeStamp></TimeStamp>
				                            <EchoToken></EchoToken>  
				                            <TransactionId></TransactionId>
                                            <Action></Action> 
                                        </h:HTNGHeader>
                                    </s:Header>
                                    <s:Body xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
                                    <OTA_HotelResNotifRQ ResStatus="" TimeStamp="" EchoToken="" Version="" xmlns="">
                                        <POS>             
				                          <Source>                
					                        <BookingChannel Type=""/>             
				                          </Source>          
			                            </POS>
                                        <HotelReservations>
                                            <HotelReservation CreatorID="" CreateDateTime="" RoomStayReservation="" ResStatus="">  
                                                <UniqueID ID_Context="" ID="" Type=""/> 
                                                <RoomStays>
                                                    <RoomStay MarketCode="">
                                                        <RoomTypes>                         
								                            <RoomType NumberOfUnits="" IsRoom="" RoomTypeCode="">                            
									                            <RoomDescription Name=""/>                         
								                            </RoomType>                      
							                            </RoomTypes>
                                                        <RatePlans> 
                                                            <RatePlan RatePlanName="" EffectiveDate="" ExpireDate="" RatePlanCode="" RatePlanType=""/>                      
                                                        </RatePlans> 
                                                        <RoomRates>                         
                                                            <RoomRate RatePlanCode="" NumberOfUnits="" ExpireDate="" EffectiveDate="" RoomTypeCode="">                            
                                                                <Rates>                               
										                            <Rate UnitMultiplier="" EffectiveDate="" ExpireDate="">                                 
											                            <Base DecimalPlaces="" CurrencyCode="" AmountBeforeTax=""/>                                  
											                            <Total DecimalPlaces="" CurrencyCode="" AmountAfterTax=""/>                               
										                            </Rate>                            
									                            </Rates>  
                                                            </RoomRate>                      
                                                        </RoomRates>  
                                                        <GuestCounts IsPerRoom=""true"">
                                                            <GuestCount AgeQualifyingCode = "" Count = "" />
                                                            <GuestCount AgeQualifyingCode = "" Count = "" />
                                                        </GuestCounts >
                                                        <TimeSpan End = "" Duration = "" Start = "" />
                                                    </RoomStay>
                                                </RoomStays>
                                                <ResGuests>                   
													<ResGuest>                     
														<Profiles>                         
															<ProfileInfo>                            
																<Profile ProfileType="">                               
																	<Customer>                                  
																		<PersonName>                                     
																			<GivenName></GSMITH</Surname>                                  
																		</PersonName>                                  
																		<Telephone PhoneNumber=""/>                                  
																		<Email></Email>                                  
																		<Address>                                     
																			<AddressLine></AddressLine>                                     
																			<CityName></CityName>                                     
																			<PostalCode></PostalCode>                                     
																			<StateProv></StateProv>                                    
																			<CountryName></CountryName>
																		</Address>                               
																	</Customer>                            
																</Profile>                         
															</ProfileInfo>                         
															<ProfileInfo>                            
																<UniqueID ID_Context="" Type=""/>
																	<Profile ProfileType="">                               
																		<CompanyInfo>                                  
																			<CompanyName CompanyShortName="" Code="" CodeContext=""/>                               
																			</CompanyInfo>                            
																	</Profile>                         
															</ProfileInfo>                         
															<ProfileInfo>                            
																<Profile ProfileType="">                               
																	<CompanyInfo>                                  
																		<CompanyName CompanyShortName=""/>                               
																	</CompanyInfo>  
																</Profile>                         
															</ProfileInfo>                      
														</Profiles>                   
													</ResGuest>                
												</ResGuests>
												<ResGlobalInfo>                   
													<HotelReservationIDs>                      
														<HotelReservationID ResID_Type="" ResID_Value="" ResID_Source="" ResID_SourceContext=""/>                      
														<HotelReservationID/>                   
													</HotelReservationIDs>                
												</ResGlobalInfo> 
                                            </HotelReservatio>
                                        </HotelReservations>
                                    </OTA_HotelResNotifRQ>
                                    </s:Body> 
                                   ");
            return null;
        }
    }
}
