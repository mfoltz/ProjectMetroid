// Decompiled with JetBrains decompiler
// Type: ProjectM.AttachMapIconToEntityAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.ContentTesting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class AttachMapIconToEntityAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MapIconPrefab;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Static_Void_MapIconAuthoring_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0;
    private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727191, XrefRangeEnd = 727192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AttachMapIconToEntityAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 727235, RefRangeEnd = 727236, XrefRangeStart = 727192, XrefRangeEnd = 727235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Convert(
      MapIconAuthoring mapIconPrefab,
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mapIconPrefab);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttachMapIconToEntityAuthoring.NativeMethodInfoPtr_Convert_Public_Static_Void_MapIconAuthoring_Entity_EntityManager_GameObjectConversionSystem_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe TestGroupFlags TestGroups
    {
      [CallerCount(26), CachedScanResults(RefRangeStart = 35341, RefRangeEnd = 35367, XrefRangeStart = 35341, XrefRangeEnd = 35367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttachMapIconToEntityAuthoring.NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TestGroupFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727236, XrefRangeEnd = 727253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Test(TestContext<GameObject> context, List<ContentIssue> outIssues)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttachMapIconToEntityAuthoring.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AttachMapIconToEntityAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttachMapIconToEntityAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttachMapIconToEntityAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AttachMapIconToEntityAuthoring()
    {
      Il2CppClassPointerStore<AttachMapIconToEntityAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AttachMapIconToEntityAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachMapIconToEntityAuthoring>.NativeClassPtr);
      AttachMapIconToEntityAuthoring.NativeFieldInfoPtr_MapIconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachMapIconToEntityAuthoring>.NativeClassPtr, nameof (MapIconPrefab));
      AttachMapIconToEntityAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachMapIconToEntityAuthoring>.NativeClassPtr, 100664338);
      AttachMapIconToEntityAuthoring.NativeMethodInfoPtr_Convert_Public_Static_Void_MapIconAuthoring_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachMapIconToEntityAuthoring>.NativeClassPtr, 100664339);
      AttachMapIconToEntityAuthoring.NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachMapIconToEntityAuthoring>.NativeClassPtr, 100664340);
      AttachMapIconToEntityAuthoring.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachMapIconToEntityAuthoring>.NativeClassPtr, 100664341);
      AttachMapIconToEntityAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachMapIconToEntityAuthoring>.NativeClassPtr, 100664342);
    }

    public AttachMapIconToEntityAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MapIconAuthoring MapIconPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttachMapIconToEntityAuthoring.NativeFieldInfoPtr_MapIconPrefab));
        return pointer == IntPtr.Zero ? (MapIconAuthoring) null : new MapIconAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttachMapIconToEntityAuthoring.NativeFieldInfoPtr_MapIconPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
