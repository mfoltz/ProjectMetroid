// Decompiled with JetBrains decompiler
// Type: ProjectM.IShowTileGridComponentData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace ProjectM
{
  public class IShowTileGridComponentData : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_Radius_Public_Abstract_Virtual_New_get_Single_0;

    public virtual unsafe float Radius
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IShowTileGridComponentData.NativeMethodInfoPtr_get_Radius_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static IShowTileGridComponentData()
    {
      Il2CppClassPointerStore<IShowTileGridComponentData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (IShowTileGridComponentData));
      IShowTileGridComponentData.NativeMethodInfoPtr_get_Radius_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IShowTileGridComponentData>.NativeClassPtr, 100664821);
    }

    public IShowTileGridComponentData(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
