// Decompiled with JetBrains decompiler
// Type: ProjectM.RagdollForceSourceAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class RagdollForceSourceAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SourceSetting;
    private static readonly IntPtr NativeFieldInfoPtr_ForceModifier;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031847, XrefRangeEnd = 1031851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RagdollForceSourceAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RagdollForceSourceAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollForceSourceAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RagdollForceSourceAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RagdollForceSourceAuthoring()
    {
      Il2CppClassPointerStore<RagdollForceSourceAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RagdollForceSourceAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollForceSourceAuthoring>.NativeClassPtr);
      RagdollForceSourceAuthoring.NativeFieldInfoPtr_SourceSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollForceSourceAuthoring>.NativeClassPtr, nameof (SourceSetting));
      RagdollForceSourceAuthoring.NativeFieldInfoPtr_ForceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollForceSourceAuthoring>.NativeClassPtr, nameof (ForceModifier));
      RagdollForceSourceAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollForceSourceAuthoring>.NativeClassPtr, 100680594);
      RagdollForceSourceAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollForceSourceAuthoring>.NativeClassPtr, 100680595);
    }

    public RagdollForceSourceAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RagdollSourceSettings SourceSetting
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollForceSourceAuthoring.NativeFieldInfoPtr_SourceSetting));
        return pointer == IntPtr.Zero ? (RagdollSourceSettings) null : new RagdollSourceSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RagdollForceSourceAuthoring.NativeFieldInfoPtr_SourceSetting), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float ForceModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollForceSourceAuthoring.NativeFieldInfoPtr_ForceModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollForceSourceAuthoring.NativeFieldInfoPtr_ForceModifier)) = value;
      }
    }
  }
}
