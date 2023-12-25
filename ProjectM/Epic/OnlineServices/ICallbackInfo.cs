// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.ICallbackInfo
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

#nullable disable
namespace Epic.OnlineServices
{
  public class ICallbackInfo : Il2CppObjectBase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_Abstract_Virtual_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetResultCode_Public_Abstract_Virtual_New_Nullable_Unboxed_1_Result_0;

    public virtual unsafe Il2CppSystem.Object ClientData
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICallbackInfo.NativeMethodInfoPtr_get_ClientData_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    public virtual unsafe Nullable_Unboxed<Result> GetResultCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICallbackInfo.NativeMethodInfoPtr_GetResultCode_Public_Abstract_Virtual_New_Nullable_Unboxed_1_Result_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Nullable_Unboxed<Result>*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ICallbackInfo()
    {
      Il2CppClassPointerStore<ICallbackInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices", nameof (ICallbackInfo));
      ICallbackInfo.NativeMethodInfoPtr_get_ClientData_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICallbackInfo>.NativeClassPtr, 100664238);
      ICallbackInfo.NativeMethodInfoPtr_GetResultCode_Public_Abstract_Virtual_New_Nullable_Unboxed_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICallbackInfo>.NativeClassPtr, 100664239);
    }

    public ICallbackInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
