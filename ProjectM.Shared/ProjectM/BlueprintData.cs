// Decompiled with JetBrains decompiler
// Type: ProjectM.BlueprintData
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
  public struct BlueprintData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlaceSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_InvalidPlaceSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_InvalidEditSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuildingSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantledSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyedSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairedSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantleFraction;
    private static readonly System.IntPtr NativeFieldInfoPtr_FullDismantleTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsStartBlueprint;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsInventoryItemBuilding;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExitBuildModeWhenBuilt;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiresLineOfSight;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiresSuccessfullPathfinding;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public PrefabGUID Guid;
    [FieldOffset(12)]
    public SequenceGUID PlaceSequence;
    [FieldOffset(16)]
    public SequenceGUID InvalidPlaceSequence;
    [FieldOffset(20)]
    public SequenceGUID EditSequence;
    [FieldOffset(24)]
    public SequenceGUID InvalidEditSequence;
    [FieldOffset(28)]
    public SequenceGUID BuildingSequence;
    [FieldOffset(32)]
    public SequenceGUID DismantledSequence;
    [FieldOffset(36)]
    public SequenceGUID DestroyedSequence;
    [FieldOffset(40)]
    public SequenceGUID RepairedSequence;
    [FieldOffset(44)]
    public float DismantleFraction;
    [FieldOffset(48)]
    public float FullDismantleTime;
    [FieldOffset(52)]
    public bool IsStartBlueprint;
    [FieldOffset(53)]
    public bool IsInventoryItemBuilding;
    [FieldOffset(54)]
    public bool ExitBuildModeWhenBuilt;
    [FieldOffset(55)]
    public bool RequiresLineOfSight;
    [FieldOffset(56)]
    public bool RequiresSuccessfullPathfinding;

    static BlueprintData()
    {
      Il2CppClassPointerStore<BlueprintData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BlueprintData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr);
      BlueprintData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, nameof (Entity));
      BlueprintData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, nameof (Guid));
      BlueprintData.NativeFieldInfoPtr_PlaceSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, nameof (PlaceSequence));
      BlueprintData.NativeFieldInfoPtr_InvalidPlaceSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, nameof (InvalidPlaceSequence));
      BlueprintData.NativeFieldInfoPtr_EditSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, nameof (EditSequence));
      BlueprintData.NativeFieldInfoPtr_InvalidEditSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, nameof (InvalidEditSequence));
      BlueprintData.NativeFieldInfoPtr_BuildingSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, nameof (BuildingSequence));
      BlueprintData.NativeFieldInfoPtr_DismantledSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, nameof (DismantledSequence));
      BlueprintData.NativeFieldInfoPtr_DestroyedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, nameof (DestroyedSequence));
      BlueprintData.NativeFieldInfoPtr_RepairedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, nameof (RepairedSequence));
      BlueprintData.NativeFieldInfoPtr_DismantleFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, nameof (DismantleFraction));
      BlueprintData.NativeFieldInfoPtr_FullDismantleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, nameof (FullDismantleTime));
      BlueprintData.NativeFieldInfoPtr_IsStartBlueprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, nameof (IsStartBlueprint));
      BlueprintData.NativeFieldInfoPtr_IsInventoryItemBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, nameof (IsInventoryItemBuilding));
      BlueprintData.NativeFieldInfoPtr_ExitBuildModeWhenBuilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, nameof (ExitBuildModeWhenBuilt));
      BlueprintData.NativeFieldInfoPtr_RequiresLineOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, nameof (RequiresLineOfSight));
      BlueprintData.NativeFieldInfoPtr_RequiresSuccessfullPathfinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, nameof (RequiresSuccessfullPathfinding));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlueprintData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
