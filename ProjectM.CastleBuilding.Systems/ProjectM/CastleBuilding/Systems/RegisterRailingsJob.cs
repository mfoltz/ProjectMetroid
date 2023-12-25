// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Systems.RegisterRailingsJob
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding.Systems
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RegisterRailingsJob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRailingType;
    private static readonly System.IntPtr NativeFieldInfoPtr_TilePositionType;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileDataType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Railings;
    private static readonly System.IntPtr NativeFieldInfoPtr_Corners;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
    [FieldOffset(0)]
    public EntityTypeHandle EntityType;
    [FieldOffset(8)]
    public ComponentTypeHandle<CastleRailing> CastleRailingType;
    [FieldOffset(40)]
    public ComponentTypeHandle<TilePosition> TilePositionType;
    [FieldOffset(72)]
    public ComponentTypeHandle<TileData> TileDataType;
    [FieldOffset(104)]
    public NativeHashMap<CastleWallBlock, Entity> Railings;
    [FieldOffset(120)]
    public NativeHashMap<CastleBlock, Entity> Corners;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204399, XrefRangeEnd = 1204423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RegisterRailingsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RegisterRailingsJob()
    {
      Il2CppClassPointerStore<RegisterRailingsJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding.Systems", nameof (RegisterRailingsJob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterRailingsJob>.NativeClassPtr);
      RegisterRailingsJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterRailingsJob>.NativeClassPtr, nameof (EntityType));
      RegisterRailingsJob.NativeFieldInfoPtr_CastleRailingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterRailingsJob>.NativeClassPtr, nameof (CastleRailingType));
      RegisterRailingsJob.NativeFieldInfoPtr_TilePositionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterRailingsJob>.NativeClassPtr, nameof (TilePositionType));
      RegisterRailingsJob.NativeFieldInfoPtr_TileDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterRailingsJob>.NativeClassPtr, nameof (TileDataType));
      RegisterRailingsJob.NativeFieldInfoPtr_Railings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterRailingsJob>.NativeClassPtr, nameof (Railings));
      RegisterRailingsJob.NativeFieldInfoPtr_Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterRailingsJob>.NativeClassPtr, nameof (Corners));
      RegisterRailingsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterRailingsJob>.NativeClassPtr, 100664654);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterRailingsJob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
