// Decompiled with JetBrains decompiler
// Type: ProjectM.Pathfinding.PathfindingTerrainData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Pathfinding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PathfindingTerrainData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TerrainTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr__B0;
    private static readonly System.IntPtr NativeFieldInfoPtr__B1;
    private static readonly System.IntPtr NativeFieldInfoPtr__B2;
    private static readonly System.IntPtr NativeFieldInfoPtr__B3;
    private static readonly System.IntPtr NativeFieldInfoPtr__B4;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_TerrainType_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Byte_TerrainType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PathfindingTerrainData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Increment_Public_Void_TerrainType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Increase_Public_Void_TerrainType_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Decrease_Public_Void_TerrainType_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reduce_Public_Static_Single_PathfindingTerrainData_PathfindingTerrainData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reduce_Public_Static_Single_PathfindingTerrainData_PathfindingTile_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_PathfindingTerrainData_PathfindingTerrainData_PathfindingTerrainData_0;
    [FieldOffset(0)]
    public PathfindingTerrainData._TerrainTypes_e__FixedBuffer TerrainTypes;
    [FieldOffset(0)]
    public byte _B0;
    [FieldOffset(1)]
    public byte _B1;
    [FieldOffset(2)]
    public byte _B2;
    [FieldOffset(3)]
    public byte _B3;
    [FieldOffset(4)]
    public byte _B4;

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 769689, RefRangeEnd = 769703, XrefRangeStart = 769689, XrefRangeEnd = 769689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(TerrainType terrainType, byte value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &terrainType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PathfindingTerrainData.NativeMethodInfoPtr_Set_Public_Void_TerrainType_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe byte Get(TerrainType terrainType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &terrainType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PathfindingTerrainData.NativeMethodInfoPtr_Get_Public_Byte_TerrainType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool Equals(PathfindingTerrainData other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PathfindingTerrainData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PathfindingTerrainData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769703, RefRangeEnd = 769704, XrefRangeStart = 769703, XrefRangeEnd = 769703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Increment(TerrainType terrainType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &terrainType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PathfindingTerrainData.NativeMethodInfoPtr_Increment_Public_Void_TerrainType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void Increase(TerrainType terrainType, byte amount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &terrainType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PathfindingTerrainData.NativeMethodInfoPtr_Increase_Public_Void_TerrainType_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void Decrease(TerrainType terrainType, byte amount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &terrainType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PathfindingTerrainData.NativeMethodInfoPtr_Decrease_Public_Void_TerrainType_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe float Reduce(PathfindingTerrainData agent, PathfindingTerrainData tile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &agent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PathfindingTerrainData.NativeMethodInfoPtr_Reduce_Public_Static_Single_PathfindingTerrainData_PathfindingTerrainData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 769704, RefRangeEnd = 769707, XrefRangeStart = 769704, XrefRangeEnd = 769704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float Reduce(PathfindingTerrainData agentTerrainData, PathfindingTile tile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &agentTerrainData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PathfindingTerrainData.NativeMethodInfoPtr_Reduce_Public_Static_Single_PathfindingTerrainData_PathfindingTile_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769707, RefRangeEnd = 769708, XrefRangeStart = 769707, XrefRangeEnd = 769707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PathfindingTerrainData operator +(
      PathfindingTerrainData a,
      PathfindingTerrainData b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PathfindingTerrainData.NativeMethodInfoPtr_op_Addition_Public_Static_PathfindingTerrainData_PathfindingTerrainData_PathfindingTerrainData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PathfindingTerrainData*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PathfindingTerrainData()
    {
      Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Pathfinding", nameof (PathfindingTerrainData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr);
      PathfindingTerrainData.NativeFieldInfoPtr_TerrainTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr, nameof (TerrainTypes));
      PathfindingTerrainData.NativeFieldInfoPtr__B0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr, nameof (_B0));
      PathfindingTerrainData.NativeFieldInfoPtr__B1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr, nameof (_B1));
      PathfindingTerrainData.NativeFieldInfoPtr__B2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr, nameof (_B2));
      PathfindingTerrainData.NativeFieldInfoPtr__B3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr, nameof (_B3));
      PathfindingTerrainData.NativeFieldInfoPtr__B4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr, nameof (_B4));
      PathfindingTerrainData.NativeMethodInfoPtr_Set_Public_Void_TerrainType_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr, 100668124);
      PathfindingTerrainData.NativeMethodInfoPtr_Get_Public_Byte_TerrainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr, 100668125);
      PathfindingTerrainData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PathfindingTerrainData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr, 100668126);
      PathfindingTerrainData.NativeMethodInfoPtr_Increment_Public_Void_TerrainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr, 100668127);
      PathfindingTerrainData.NativeMethodInfoPtr_Increase_Public_Void_TerrainType_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr, 100668128);
      PathfindingTerrainData.NativeMethodInfoPtr_Decrease_Public_Void_TerrainType_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr, 100668129);
      PathfindingTerrainData.NativeMethodInfoPtr_Reduce_Public_Static_Single_PathfindingTerrainData_PathfindingTerrainData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr, 100668130);
      PathfindingTerrainData.NativeMethodInfoPtr_Reduce_Public_Static_Single_PathfindingTerrainData_PathfindingTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr, 100668131);
      PathfindingTerrainData.NativeMethodInfoPtr_op_Addition_Public_Static_PathfindingTerrainData_PathfindingTerrainData_PathfindingTerrainData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr, 100668132);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [ObfuscatedName("ProjectM.Pathfinding.PathfindingTerrainData/<TerrainTypes>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _TerrainTypes_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public byte FixedElementField;

      static _TerrainTypes_e__FixedBuffer()
      {
        Il2CppClassPointerStore<PathfindingTerrainData._TerrainTypes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathfindingTerrainData>.NativeClassPtr, "<TerrainTypes>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathfindingTerrainData._TerrainTypes_e__FixedBuffer>.NativeClassPtr);
        PathfindingTerrainData._TerrainTypes_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathfindingTerrainData._TerrainTypes_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PathfindingTerrainData._TerrainTypes_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
