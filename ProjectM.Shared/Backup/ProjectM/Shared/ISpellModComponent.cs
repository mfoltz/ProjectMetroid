// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ISpellModComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace ProjectM.Shared
{
  public class ISpellModComponent : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_ShouldApplyOnClient_Public_Abstract_Virtual_New_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetSpellModPrefabGuid_Public_Abstract_Virtual_New_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_HasCondition_Public_Abstract_Virtual_New_Boolean_0;

    [CallerCount(0)]
    public virtual unsafe bool ShouldApplyOnClient()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISpellModComponent.NativeMethodInfoPtr_ShouldApplyOnClient_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe PrefabGUID GetSpellModPrefabGuid()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISpellModComponent.NativeMethodInfoPtr_GetSpellModPrefabGuid_Public_Abstract_Virtual_New_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool HasCondition()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISpellModComponent.NativeMethodInfoPtr_HasCondition_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ISpellModComponent()
    {
      Il2CppClassPointerStore<ISpellModComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (ISpellModComponent));
      ISpellModComponent.NativeMethodInfoPtr_ShouldApplyOnClient_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpellModComponent>.NativeClassPtr, 100670419);
      ISpellModComponent.NativeMethodInfoPtr_GetSpellModPrefabGuid_Public_Abstract_Virtual_New_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpellModComponent>.NativeClassPtr, 100670420);
      ISpellModComponent.NativeMethodInfoPtr_HasCondition_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpellModComponent>.NativeClassPtr, 100670421);
    }

    public ISpellModComponent(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
