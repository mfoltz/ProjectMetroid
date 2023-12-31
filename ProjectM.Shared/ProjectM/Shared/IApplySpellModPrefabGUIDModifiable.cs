// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.IApplySpellModPrefabGUIDModifiable
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
  public class IApplySpellModPrefabGUIDModifiable : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_ApplyPrefabGUID_Public_Abstract_Virtual_New_ModificationId_SpellModPrefabGuidModifiable_0;

    [CallerCount(0)]
    public virtual unsafe ModificationId ApplyPrefabGUID(SpellModPrefabGuidModifiable spellMod)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &spellMod;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IApplySpellModPrefabGUIDModifiable.NativeMethodInfoPtr_ApplyPrefabGUID_Public_Abstract_Virtual_New_ModificationId_SpellModPrefabGuidModifiable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    static IApplySpellModPrefabGUIDModifiable()
    {
      Il2CppClassPointerStore<IApplySpellModPrefabGUIDModifiable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (IApplySpellModPrefabGUIDModifiable));
      IApplySpellModPrefabGUIDModifiable.NativeMethodInfoPtr_ApplyPrefabGUID_Public_Abstract_Virtual_New_ModificationId_SpellModPrefabGuidModifiable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IApplySpellModPrefabGUIDModifiable>.NativeClassPtr, 100670533);
    }

    public IApplySpellModPrefabGUIDModifiable(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
