// Decompiled with JetBrains decompiler
// Type: ProjectM.UpdateStaticHierarchyJob
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Rendering;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UpdateStaticHierarchyJob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UpdatePreviousMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticHierarchyBufferType;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticHierarchyDataType;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetLocalToWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetMatrixPreviousM;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
    [FieldOffset(0)]
    public bool UpdatePreviousMatrix;
    [FieldOffset(4)]
    public EntityTypeHandle EntityType;
    [FieldOffset(8)]
    public BufferTypeHandle<StaticHierarchyBuffer> StaticHierarchyBufferType;
    [FieldOffset(48)]
    public ComponentTypeHandle<StaticHierarchyData> StaticHierarchyDataType;
    [FieldOffset(80)]
    public ComponentDataFromEntity<LocalToWorld> GetLocalToWorld;
    [FieldOffset(112)]
    public ComponentDataFromEntity<BuiltinMaterialPropertyUnity_MatrixPreviousM> GetMatrixPreviousM;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073156, XrefRangeEnd = 1073196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateStaticHierarchyJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UpdateStaticHierarchyJob()
    {
      Il2CppClassPointerStore<UpdateStaticHierarchyJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UpdateStaticHierarchyJob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateStaticHierarchyJob>.NativeClassPtr);
      UpdateStaticHierarchyJob.NativeFieldInfoPtr_UpdatePreviousMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticHierarchyJob>.NativeClassPtr, nameof (UpdatePreviousMatrix));
      UpdateStaticHierarchyJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticHierarchyJob>.NativeClassPtr, nameof (EntityType));
      UpdateStaticHierarchyJob.NativeFieldInfoPtr_StaticHierarchyBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticHierarchyJob>.NativeClassPtr, nameof (StaticHierarchyBufferType));
      UpdateStaticHierarchyJob.NativeFieldInfoPtr_StaticHierarchyDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticHierarchyJob>.NativeClassPtr, nameof (StaticHierarchyDataType));
      UpdateStaticHierarchyJob.NativeFieldInfoPtr_GetLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticHierarchyJob>.NativeClassPtr, nameof (GetLocalToWorld));
      UpdateStaticHierarchyJob.NativeFieldInfoPtr_GetMatrixPreviousM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticHierarchyJob>.NativeClassPtr, nameof (GetMatrixPreviousM));
      UpdateStaticHierarchyJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateStaticHierarchyJob>.NativeClassPtr, 100684542);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateStaticHierarchyJob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
