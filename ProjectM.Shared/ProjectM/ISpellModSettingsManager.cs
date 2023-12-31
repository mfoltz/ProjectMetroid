// Decompiled with JetBrains decompiler
// Type: ProjectM.ISpellModSettingsManager
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;

#nullable disable
namespace ProjectM
{
  public class ISpellModSettingsManager : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_SpellModSettings_Public_Abstract_Virtual_New_get_IEnumerable_1_SpellModSettings_0;

    public virtual unsafe IEnumerable<ProjectM.SpellModSettings> SpellModSettings
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISpellModSettingsManager.NativeMethodInfoPtr_get_SpellModSettings_Public_Abstract_Virtual_New_get_IEnumerable_1_SpellModSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IEnumerable<ProjectM.SpellModSettings>) null : new IEnumerable<ProjectM.SpellModSettings>(pointer);
      }
    }

    static ISpellModSettingsManager()
    {
      Il2CppClassPointerStore<ISpellModSettingsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ISpellModSettingsManager));
      ISpellModSettingsManager.NativeMethodInfoPtr_get_SpellModSettings_Public_Abstract_Virtual_New_get_IEnumerable_1_SpellModSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpellModSettingsManager>.NativeClassPtr, 100664526);
    }

    public ISpellModSettingsManager(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
