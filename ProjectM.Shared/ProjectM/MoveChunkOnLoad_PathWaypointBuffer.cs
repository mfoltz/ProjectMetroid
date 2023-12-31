// Decompiled with JetBrains decompiler
// Type: ProjectM.MoveChunkOnLoad_PathWaypointBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public class MoveChunkOnLoad_PathWaypointBuffer : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__OffsetQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ProcessChunkTask_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747187, XrefRangeEnd = 747205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MoveChunkOnLoad_PathWaypointBuffer.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747205, XrefRangeEnd = 747225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MoveChunkOnLoad_PathWaypointBuffer.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MoveChunkOnLoad_PathWaypointBuffer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveChunkOnLoad_PathWaypointBuffer>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoveChunkOnLoad_PathWaypointBuffer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747225, XrefRangeEnd = 747233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MoveChunkOnLoad_PathWaypointBuffer.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MoveChunkOnLoad_PathWaypointBuffer()
    {
      Il2CppClassPointerStore<MoveChunkOnLoad_PathWaypointBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MoveChunkOnLoad_PathWaypointBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveChunkOnLoad_PathWaypointBuffer>.NativeClassPtr);
      MoveChunkOnLoad_PathWaypointBuffer.NativeFieldInfoPtr__OffsetQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveChunkOnLoad_PathWaypointBuffer>.NativeClassPtr, nameof (_OffsetQuery));
      MoveChunkOnLoad_PathWaypointBuffer.NativeFieldInfoPtr__SingletonEntityQuery_ProcessChunkTask_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveChunkOnLoad_PathWaypointBuffer>.NativeClassPtr, nameof (_SingletonEntityQuery_ProcessChunkTask_1));
      MoveChunkOnLoad_PathWaypointBuffer.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveChunkOnLoad_PathWaypointBuffer>.NativeClassPtr, 100665779);
      MoveChunkOnLoad_PathWaypointBuffer.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveChunkOnLoad_PathWaypointBuffer>.NativeClassPtr, 100665780);
      MoveChunkOnLoad_PathWaypointBuffer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveChunkOnLoad_PathWaypointBuffer>.NativeClassPtr, 100665781);
      MoveChunkOnLoad_PathWaypointBuffer.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveChunkOnLoad_PathWaypointBuffer>.NativeClassPtr, 100665782);
    }

    public MoveChunkOnLoad_PathWaypointBuffer(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _OffsetQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveChunkOnLoad_PathWaypointBuffer.NativeFieldInfoPtr__OffsetQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveChunkOnLoad_PathWaypointBuffer.NativeFieldInfoPtr__OffsetQuery)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ProcessChunkTask_1
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveChunkOnLoad_PathWaypointBuffer.NativeFieldInfoPtr__SingletonEntityQuery_ProcessChunkTask_1));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveChunkOnLoad_PathWaypointBuffer.NativeFieldInfoPtr__SingletonEntityQuery_ProcessChunkTask_1)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct OffsetDataJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ComponentType;
      private static readonly System.IntPtr NativeFieldInfoPtr_WaitComponentType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TransformationMatrix;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<PathWaypointNode> ComponentType;
      [FieldOffset(32)]
      public ComponentTypeHandle<PathWaypointNodeWait> WaitComponentType;
      [FieldOffset(64)]
      public float4x4 TransformationMatrix;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747159, XrefRangeEnd = 747187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveChunkOnLoad_PathWaypointBuffer.OffsetDataJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OffsetDataJob()
      {
        Il2CppClassPointerStore<MoveChunkOnLoad_PathWaypointBuffer.OffsetDataJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveChunkOnLoad_PathWaypointBuffer>.NativeClassPtr, nameof (OffsetDataJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveChunkOnLoad_PathWaypointBuffer.OffsetDataJob>.NativeClassPtr);
        MoveChunkOnLoad_PathWaypointBuffer.OffsetDataJob.NativeFieldInfoPtr_ComponentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveChunkOnLoad_PathWaypointBuffer.OffsetDataJob>.NativeClassPtr, nameof (ComponentType));
        MoveChunkOnLoad_PathWaypointBuffer.OffsetDataJob.NativeFieldInfoPtr_WaitComponentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveChunkOnLoad_PathWaypointBuffer.OffsetDataJob>.NativeClassPtr, nameof (WaitComponentType));
        MoveChunkOnLoad_PathWaypointBuffer.OffsetDataJob.NativeFieldInfoPtr_TransformationMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveChunkOnLoad_PathWaypointBuffer.OffsetDataJob>.NativeClassPtr, nameof (TransformationMatrix));
        MoveChunkOnLoad_PathWaypointBuffer.OffsetDataJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveChunkOnLoad_PathWaypointBuffer.OffsetDataJob>.NativeClassPtr, 100665783);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveChunkOnLoad_PathWaypointBuffer.OffsetDataJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
