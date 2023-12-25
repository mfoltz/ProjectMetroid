// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.StaticTransformUpdateSystem_Update_Server
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Network
{
  public class StaticTransformUpdateSystem_Update_Server : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__UpdateStaticTransformQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1626013, XrefRangeEnd = 1626045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StaticTransformUpdateSystem_Update_Server.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1626045, XrefRangeEnd = 1626060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StaticTransformUpdateSystem_Update_Server.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StaticTransformUpdateSystem_Update_Server()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticTransformUpdateSystem_Update_Server>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StaticTransformUpdateSystem_Update_Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StaticTransformUpdateSystem_Update_Server.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StaticTransformUpdateSystem_Update_Server()
    {
      Il2CppClassPointerStore<StaticTransformUpdateSystem_Update_Server>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (StaticTransformUpdateSystem_Update_Server));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticTransformUpdateSystem_Update_Server>.NativeClassPtr);
      StaticTransformUpdateSystem_Update_Server.NativeFieldInfoPtr__UpdateStaticTransformQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformUpdateSystem_Update_Server>.NativeClassPtr, nameof (_UpdateStaticTransformQuery));
      StaticTransformUpdateSystem_Update_Server.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTransformUpdateSystem_Update_Server>.NativeClassPtr, 100665861);
      StaticTransformUpdateSystem_Update_Server.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTransformUpdateSystem_Update_Server>.NativeClassPtr, 100665862);
      StaticTransformUpdateSystem_Update_Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTransformUpdateSystem_Update_Server>.NativeClassPtr, 100665863);
      StaticTransformUpdateSystem_Update_Server.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTransformUpdateSystem_Update_Server>.NativeClassPtr, 100665864);
    }

    public StaticTransformUpdateSystem_Update_Server(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _UpdateStaticTransformQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StaticTransformUpdateSystem_Update_Server.NativeFieldInfoPtr__UpdateStaticTransformQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StaticTransformUpdateSystem_Update_Server.NativeFieldInfoPtr__UpdateStaticTransformQuery)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UpdateStaticTransformJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TranslationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_RotationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatibleType;
      private static readonly System.IntPtr NativeFieldInfoPtr_LastSystemVersion;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<Translation> TranslationType;
      [FieldOffset(32)]
      public ComponentTypeHandle<Rotation> RotationType;
      [FieldOffset(64)]
      public ComponentTypeHandle<StaticTransformCompatible> StaticTransformCompatibleType;
      [FieldOffset(96)]
      public uint LastSystemVersion;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1625982, XrefRangeEnd = 1626013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StaticTransformUpdateSystem_Update_Server.UpdateStaticTransformJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UpdateStaticTransformJob()
      {
        Il2CppClassPointerStore<StaticTransformUpdateSystem_Update_Server.UpdateStaticTransformJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StaticTransformUpdateSystem_Update_Server>.NativeClassPtr, nameof (UpdateStaticTransformJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticTransformUpdateSystem_Update_Server.UpdateStaticTransformJob>.NativeClassPtr);
        StaticTransformUpdateSystem_Update_Server.UpdateStaticTransformJob.NativeFieldInfoPtr_TranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformUpdateSystem_Update_Server.UpdateStaticTransformJob>.NativeClassPtr, nameof (TranslationType));
        StaticTransformUpdateSystem_Update_Server.UpdateStaticTransformJob.NativeFieldInfoPtr_RotationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformUpdateSystem_Update_Server.UpdateStaticTransformJob>.NativeClassPtr, nameof (RotationType));
        StaticTransformUpdateSystem_Update_Server.UpdateStaticTransformJob.NativeFieldInfoPtr_StaticTransformCompatibleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformUpdateSystem_Update_Server.UpdateStaticTransformJob>.NativeClassPtr, nameof (StaticTransformCompatibleType));
        StaticTransformUpdateSystem_Update_Server.UpdateStaticTransformJob.NativeFieldInfoPtr_LastSystemVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformUpdateSystem_Update_Server.UpdateStaticTransformJob>.NativeClassPtr, nameof (LastSystemVersion));
        StaticTransformUpdateSystem_Update_Server.UpdateStaticTransformJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTransformUpdateSystem_Update_Server.UpdateStaticTransformJob>.NativeClassPtr, 100665865);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StaticTransformUpdateSystem_Update_Server.UpdateStaticTransformJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
