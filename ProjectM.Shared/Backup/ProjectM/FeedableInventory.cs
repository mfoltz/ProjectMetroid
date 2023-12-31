// Decompiled with JetBrains decompiler
// Type: ProjectM.FeedableInventory
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FeedableInventory
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FeedableInventoryEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_InventoryPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredItemType;
    private static readonly System.IntPtr NativeFieldInfoPtr_FeedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FeedProgressTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageTickDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageTickTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageTickPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthRegenModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsActive;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsFed;
    [FieldOffset(0)]
    public NetworkedEntity FeedableInventoryEntity;
    [FieldOffset(12)]
    public PrefabGUID InventoryPrefabGuid;
    [FieldOffset(16)]
    public PrefabGUID RequiredItemType;
    [FieldOffset(20)]
    public float FeedTime;
    [FieldOffset(24)]
    public float FeedProgressTime;
    [FieldOffset(28)]
    public float DamageTickDuration;
    [FieldOffset(32)]
    public float DamageTickTime;
    [FieldOffset(36)]
    public float DamageTickPercentage;
    [FieldOffset(40)]
    public ModificationId HealthRegenModifier;
    [FieldOffset(44)]
    public bool IsActive;
    [FieldOffset(45)]
    public bool IsFed;

    static FeedableInventory()
    {
      Il2CppClassPointerStore<FeedableInventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (FeedableInventory));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedableInventory>.NativeClassPtr);
      FeedableInventory.NativeFieldInfoPtr_FeedableInventoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedableInventory>.NativeClassPtr, nameof (FeedableInventoryEntity));
      FeedableInventory.NativeFieldInfoPtr_InventoryPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedableInventory>.NativeClassPtr, nameof (InventoryPrefabGuid));
      FeedableInventory.NativeFieldInfoPtr_RequiredItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedableInventory>.NativeClassPtr, nameof (RequiredItemType));
      FeedableInventory.NativeFieldInfoPtr_FeedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedableInventory>.NativeClassPtr, nameof (FeedTime));
      FeedableInventory.NativeFieldInfoPtr_FeedProgressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedableInventory>.NativeClassPtr, nameof (FeedProgressTime));
      FeedableInventory.NativeFieldInfoPtr_DamageTickDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedableInventory>.NativeClassPtr, nameof (DamageTickDuration));
      FeedableInventory.NativeFieldInfoPtr_DamageTickTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedableInventory>.NativeClassPtr, nameof (DamageTickTime));
      FeedableInventory.NativeFieldInfoPtr_DamageTickPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedableInventory>.NativeClassPtr, nameof (DamageTickPercentage));
      FeedableInventory.NativeFieldInfoPtr_HealthRegenModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedableInventory>.NativeClassPtr, nameof (HealthRegenModifier));
      FeedableInventory.NativeFieldInfoPtr_IsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedableInventory>.NativeClassPtr, nameof (IsActive));
      FeedableInventory.NativeFieldInfoPtr_IsFed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedableInventory>.NativeClassPtr, nameof (IsFed));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FeedableInventory>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
