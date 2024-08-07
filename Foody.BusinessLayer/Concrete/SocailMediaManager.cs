﻿using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;

namespace Foody.BusinessLayer.Concrete
{
	public class SocailMediaManager : ISocialMediaService
	{
		private readonly ISocialMediaDal _socialMediaDal;
		public SocailMediaManager(ISocialMediaDal socialMediaDal)
		{
			_socialMediaDal= socialMediaDal;
		}
		public void TDelete(int id)
		{
			_socialMediaDal.Delete(id);
		}

		public List<SocialMedia> TGetAll()
		{
			return _socialMediaDal.GetAll();
		}

		public SocialMedia TGetById(int id)
		{
			return _socialMediaDal.GetById(id);
		}

		public void TInsert(SocialMedia entity)
		{
			_socialMediaDal.Update(entity);
		}

		public void TUpdate(SocialMedia entity)
		{
			_socialMediaDal.Update(entity);

		}
	}
}
