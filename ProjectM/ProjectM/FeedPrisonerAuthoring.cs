// Decompiled with JetBrains decompiler
// Type: ProjectM.FeedPrisonerAuthoring
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
  public class FeedPrisonerAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_RecoverHealth_Min;
    private static readonly IntPtr NativeFieldInfoPtr_RecoverHealth_Max;
    private static readonly IntPtr NativeFieldInfoPtr_RecoverMisery_Min;
    private static readonly IntPtr NativeFieldInfoPtr_RecoverMisery_Max;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024553, XrefRangeEnd = 1024556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(FeedPrisonerAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FeedPrisonerAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedPrisonerAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FeedPrisonerAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FeedPrisonerAuthoring()
    {
      Il2CppClassPointerStore<FeedPrisonerAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (FeedPrisonerAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedPrisonerAuthoring>.NativeClassPtr);
      FeedPrisonerAuthoring.NativeFieldInfoPtr_RecoverHealth_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedPrisonerAuthoring>.NativeClassPtr, nameof (RecoverHealth_Min));
      FeedPrisonerAuthoring.NativeFieldInfoPtr_RecoverHealth_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedPrisonerAuthoring>.NativeClassPtr, nameof (RecoverHealth_Max));
      FeedPrisonerAuthoring.NativeFieldInfoPtr_RecoverMisery_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedPrisonerAuthoring>.NativeClassPtr, nameof (RecoverMisery_Min));
      FeedPrisonerAuthoring.NativeFieldInfoPtr_RecoverMisery_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedPrisonerAuthoring>.NativeClassPtr, nameof (RecoverMisery_Max));
      FeedPrisonerAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedPrisonerAuthoring>.NativeClassPtr, 100680019);
      FeedPrisonerAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedPrisonerAuthoring>.NativeClassPtr, 100680020);
    }

    public FeedPrisonerAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float RecoverHealth_Min
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedPrisonerAuthoring.NativeFieldInfoPtr_RecoverHealth_Min));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedPrisonerAuthoring.NativeFieldInfoPtr_RecoverHealth_Min)) = value;
      }
    }

    public unsafe float RecoverHealth_Max
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedPrisonerAuthoring.NativeFieldInfoPtr_RecoverHealth_Max));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedPrisonerAuthoring.NativeFieldInfoPtr_RecoverHealth_Max)) = value;
      }
    }

    public unsafe float RecoverMisery_Min
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedPrisonerAuthoring.NativeFieldInfoPtr_RecoverMisery_Min));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedPrisonerAuthoring.NativeFieldInfoPtr_RecoverMisery_Min)) = value;
      }
    }

    public unsafe float RecoverMisery_Max
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedPrisonerAuthoring.NativeFieldInfoPtr_RecoverMisery_Max));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedPrisonerAuthoring.NativeFieldInfoPtr_RecoverMisery_Max)) = value;
      }
    }
  }
}
