// Decompiled with JetBrains decompiler
// Type: ProjectM.IRequirementBuffer
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
  public class IRequirementBuffer : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_Guid_Public_Abstract_Virtual_New_get_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Amount_Public_Abstract_Virtual_New_get_Int32_0;

    public virtual unsafe PrefabGUID Guid
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRequirementBuffer.NativeMethodInfoPtr_get_Guid_Public_Abstract_Virtual_New_get_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public virtual unsafe int Amount
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRequirementBuffer.NativeMethodInfoPtr_get_Amount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static IRequirementBuffer()
    {
      Il2CppClassPointerStore<IRequirementBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (IRequirementBuffer));
      IRequirementBuffer.NativeMethodInfoPtr_get_Guid_Public_Abstract_Virtual_New_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRequirementBuffer>.NativeClassPtr, 100664701);
      IRequirementBuffer.NativeMethodInfoPtr_get_Amount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRequirementBuffer>.NativeClassPtr, 100664702);
    }

    public IRequirementBuffer(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
