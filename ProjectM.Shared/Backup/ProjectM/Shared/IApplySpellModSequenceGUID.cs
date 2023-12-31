// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.IApplySpellModSequenceGUID
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
  public class IApplySpellModSequenceGUID : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_ApplySequenceGUID_Public_Abstract_Virtual_New_Void_SpellModSequenceGuid_0;

    [CallerCount(0)]
    public virtual unsafe void ApplySequenceGUID(SpellModSequenceGuid spellMod)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &spellMod;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IApplySpellModSequenceGUID.NativeMethodInfoPtr_ApplySequenceGUID_Public_Abstract_Virtual_New_Void_SpellModSequenceGuid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IApplySpellModSequenceGUID()
    {
      Il2CppClassPointerStore<IApplySpellModSequenceGUID>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (IApplySpellModSequenceGUID));
      IApplySpellModSequenceGUID.NativeMethodInfoPtr_ApplySequenceGUID_Public_Abstract_Virtual_New_Void_SpellModSequenceGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IApplySpellModSequenceGUID>.NativeClassPtr, 100670537);
    }

    public IApplySpellModSequenceGUID(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
