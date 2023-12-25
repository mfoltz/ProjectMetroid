// Decompiled with JetBrains decompiler
// Type: ProjectM.UpdateAttachedTranslationSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class UpdateAttachedTranslationSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999682, XrefRangeEnd = 999717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateAttachedTranslationSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999717, XrefRangeEnd = 999731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateAttachedTranslationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UpdateAttachedTranslationSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateAttachedTranslationSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateAttachedTranslationSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateAttachedTranslationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UpdateAttachedTranslationSystem()
    {
      Il2CppClassPointerStore<UpdateAttachedTranslationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UpdateAttachedTranslationSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateAttachedTranslationSystem>.NativeClassPtr);
      UpdateAttachedTranslationSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateAttachedTranslationSystem>.NativeClassPtr, nameof (_Query));
      UpdateAttachedTranslationSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateAttachedTranslationSystem>.NativeClassPtr, 100677347);
      UpdateAttachedTranslationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateAttachedTranslationSystem>.NativeClassPtr, 100677348);
      UpdateAttachedTranslationSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateAttachedTranslationSystem>.NativeClassPtr, 100677349);
      UpdateAttachedTranslationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateAttachedTranslationSystem>.NativeClassPtr, 100677350);
    }

    public UpdateAttachedTranslationSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateAttachedTranslationSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateAttachedTranslationSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UpdateTranslationJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TranslationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_AttachType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTranslation;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<Translation> TranslationType;
      [FieldOffset(32)]
      public ComponentTypeHandle<Attach> AttachType;
      [FieldOffset(64)]
      public ComponentDataFromEntity<Translation> GetTranslation;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999670, XrefRangeEnd = 999682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(UpdateAttachedTranslationSystem.UpdateTranslationJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UpdateTranslationJob()
      {
        Il2CppClassPointerStore<UpdateAttachedTranslationSystem.UpdateTranslationJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateAttachedTranslationSystem>.NativeClassPtr, nameof (UpdateTranslationJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateAttachedTranslationSystem.UpdateTranslationJob>.NativeClassPtr);
        UpdateAttachedTranslationSystem.UpdateTranslationJob.NativeFieldInfoPtr_TranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateAttachedTranslationSystem.UpdateTranslationJob>.NativeClassPtr, nameof (TranslationType));
        UpdateAttachedTranslationSystem.UpdateTranslationJob.NativeFieldInfoPtr_AttachType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateAttachedTranslationSystem.UpdateTranslationJob>.NativeClassPtr, nameof (AttachType));
        UpdateAttachedTranslationSystem.UpdateTranslationJob.NativeFieldInfoPtr_GetTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateAttachedTranslationSystem.UpdateTranslationJob>.NativeClassPtr, nameof (GetTranslation));
        UpdateAttachedTranslationSystem.UpdateTranslationJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateAttachedTranslationSystem.UpdateTranslationJob>.NativeClassPtr, 100677351);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateAttachedTranslationSystem.UpdateTranslationJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
