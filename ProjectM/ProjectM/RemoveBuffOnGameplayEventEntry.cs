// Decompiled with JetBrains decompiler
// Type: ProjectM.RemoveBuffOnGameplayEventEntry
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RemoveBuffOnGameplayEventEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffCategoryFlag;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncludeSelf;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPrefabGUID_Public_Virtual_Final_New_Void_SpellModPrefabGuid_PrefabGUID_0;
    [FieldOffset(0)]
    public int EventIndex;
    [FieldOffset(4)]
    public PrefabGUID Buff;
    [FieldOffset(8)]
    public BuffCategoryFlag BuffCategoryFlag;
    [FieldOffset(16)]
    public bool IncludeSelf;

    [CallerCount(0)]
    public virtual unsafe void ApplyPrefabGUID(SpellModPrefabGuid spellMod, PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RemoveBuffOnGameplayEventEntry.NativeMethodInfoPtr_ApplyPrefabGUID_Public_Virtual_Final_New_Void_SpellModPrefabGuid_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RemoveBuffOnGameplayEventEntry()
    {
      Il2CppClassPointerStore<RemoveBuffOnGameplayEventEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RemoveBuffOnGameplayEventEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveBuffOnGameplayEventEntry>.NativeClassPtr);
      RemoveBuffOnGameplayEventEntry.NativeFieldInfoPtr_EventIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveBuffOnGameplayEventEntry>.NativeClassPtr, nameof (EventIndex));
      RemoveBuffOnGameplayEventEntry.NativeFieldInfoPtr_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveBuffOnGameplayEventEntry>.NativeClassPtr, nameof (Buff));
      RemoveBuffOnGameplayEventEntry.NativeFieldInfoPtr_BuffCategoryFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveBuffOnGameplayEventEntry>.NativeClassPtr, nameof (BuffCategoryFlag));
      RemoveBuffOnGameplayEventEntry.NativeFieldInfoPtr_IncludeSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveBuffOnGameplayEventEntry>.NativeClassPtr, nameof (IncludeSelf));
      RemoveBuffOnGameplayEventEntry.NativeMethodInfoPtr_ApplyPrefabGUID_Public_Virtual_Final_New_Void_SpellModPrefabGuid_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveBuffOnGameplayEventEntry>.NativeClassPtr, 100678328);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveBuffOnGameplayEventEntry>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
