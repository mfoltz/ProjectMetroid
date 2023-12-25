// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnPrefabOnGameplayEvent
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
  public struct SpawnPrefabOnGameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_Owner;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPrefabGUID_Public_Virtual_Final_New_Void_SpellModPrefabGuid_PrefabGUID_0;
    [FieldOffset(0)]
    public PrefabGUID SpawnPrefab;
    [FieldOffset(4)]
    public SetSpellTarget SpellTarget;
    [FieldOffset(8)]
    public SpawnPrefabOnGameplayEventOwner Owner;

    [CallerCount(0)]
    public virtual unsafe void ApplyPrefabGUID(SpellModPrefabGuid spellMod, PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnPrefabOnGameplayEvent.NativeMethodInfoPtr_ApplyPrefabGUID_Public_Virtual_Final_New_Void_SpellModPrefabGuid_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnPrefabOnGameplayEvent()
    {
      Il2CppClassPointerStore<SpawnPrefabOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SpawnPrefabOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnPrefabOnGameplayEvent>.NativeClassPtr);
      SpawnPrefabOnGameplayEvent.NativeFieldInfoPtr_SpawnPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnPrefabOnGameplayEvent>.NativeClassPtr, nameof (SpawnPrefab));
      SpawnPrefabOnGameplayEvent.NativeFieldInfoPtr_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnPrefabOnGameplayEvent>.NativeClassPtr, nameof (SpellTarget));
      SpawnPrefabOnGameplayEvent.NativeFieldInfoPtr_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnPrefabOnGameplayEvent>.NativeClassPtr, nameof (Owner));
      SpawnPrefabOnGameplayEvent.NativeMethodInfoPtr_ApplyPrefabGUID_Public_Virtual_Final_New_Void_SpellModPrefabGuid_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnPrefabOnGameplayEvent>.NativeClassPtr, 100678355);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnPrefabOnGameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
