// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnMinionOnGameplayEventBlob
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpawnMinionOnGameplayEventBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Minions;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnBuffs;
    [FieldOffset(0)]
    public BlobArray<SpawnMinionOnGameplayEventBlob.MinionElement> Minions;
    [FieldOffset(8)]
    public BlobArray<SpawnMinionOnGameplayEventBlob.SpawnBuffElement> SpawnBuffs;

    static SpawnMinionOnGameplayEventBlob()
    {
      Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnMinionOnGameplayEventBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob>.NativeClassPtr);
      SpawnMinionOnGameplayEventBlob.NativeFieldInfoPtr_Minions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob>.NativeClassPtr, nameof (Minions));
      SpawnMinionOnGameplayEventBlob.NativeFieldInfoPtr_SpawnBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob>.NativeClassPtr, nameof (SpawnBuffs));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MinionElement
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_DynamicallyWeakenAttackersOverride;
      [FieldOffset(0)]
      public PrefabGUID PrefabGuid;
      [FieldOffset(4)]
      public DynamicallyWeakenAttackers DynamicallyWeakenAttackersOverride;

      static MinionElement()
      {
        Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob.MinionElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob>.NativeClassPtr, nameof (MinionElement));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob.MinionElement>.NativeClassPtr);
        SpawnMinionOnGameplayEventBlob.MinionElement.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob.MinionElement>.NativeClassPtr, nameof (PrefabGuid));
        SpawnMinionOnGameplayEventBlob.MinionElement.NativeFieldInfoPtr_DynamicallyWeakenAttackersOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob.MinionElement>.NativeClassPtr, nameof (DynamicallyWeakenAttackersOverride));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob.MinionElement>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SpawnBuffElement
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_BuffGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_BuffTarget;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpellTarget;
      [FieldOffset(0)]
      public PrefabGUID BuffGuid;
      [FieldOffset(4)]
      public SpawnMinionOnGameplayEventWho BuffTarget;
      [FieldOffset(8)]
      public SpawnMinionOnGameplayEventWho SpellTarget;

      static SpawnBuffElement()
      {
        Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob.SpawnBuffElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob>.NativeClassPtr, nameof (SpawnBuffElement));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob.SpawnBuffElement>.NativeClassPtr);
        SpawnMinionOnGameplayEventBlob.SpawnBuffElement.NativeFieldInfoPtr_BuffGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob.SpawnBuffElement>.NativeClassPtr, nameof (BuffGuid));
        SpawnMinionOnGameplayEventBlob.SpawnBuffElement.NativeFieldInfoPtr_BuffTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob.SpawnBuffElement>.NativeClassPtr, nameof (BuffTarget));
        SpawnMinionOnGameplayEventBlob.SpawnBuffElement.NativeFieldInfoPtr_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob.SpawnBuffElement>.NativeClassPtr, nameof (SpellTarget));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnMinionOnGameplayEventBlob.SpawnBuffElement>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
