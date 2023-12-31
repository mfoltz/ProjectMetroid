// Decompiled with JetBrains decompiler
// Type: ProjectM.DropItemAroundPosition
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DropItemAroundPosition
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemHash;
    private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomDropArcPrefab;
    [FieldOffset(0)]
    public float3 Position;
    [FieldOffset(12)]
    public Nullable_Unboxed<float2> Direction;
    [FieldOffset(24)]
    public Nullable_Unboxed<float> MinRange;
    [FieldOffset(32)]
    public Nullable_Unboxed<float> MaxRange;
    [FieldOffset(40)]
    public Entity ItemEntity;
    [FieldOffset(48)]
    public PrefabGUID ItemHash;
    [FieldOffset(52)]
    public int Amount;
    [FieldOffset(56)]
    public Nullable_Unboxed<Entity> CustomDropArcPrefab;

    static DropItemAroundPosition()
    {
      Il2CppClassPointerStore<DropItemAroundPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DropItemAroundPosition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropItemAroundPosition>.NativeClassPtr);
      DropItemAroundPosition.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemAroundPosition>.NativeClassPtr, nameof (Position));
      DropItemAroundPosition.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemAroundPosition>.NativeClassPtr, nameof (Direction));
      DropItemAroundPosition.NativeFieldInfoPtr_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemAroundPosition>.NativeClassPtr, nameof (MinRange));
      DropItemAroundPosition.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemAroundPosition>.NativeClassPtr, nameof (MaxRange));
      DropItemAroundPosition.NativeFieldInfoPtr_ItemEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemAroundPosition>.NativeClassPtr, nameof (ItemEntity));
      DropItemAroundPosition.NativeFieldInfoPtr_ItemHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemAroundPosition>.NativeClassPtr, nameof (ItemHash));
      DropItemAroundPosition.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemAroundPosition>.NativeClassPtr, nameof (Amount));
      DropItemAroundPosition.NativeFieldInfoPtr_CustomDropArcPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemAroundPosition>.NativeClassPtr, nameof (CustomDropArcPrefab));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropItemAroundPosition>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
