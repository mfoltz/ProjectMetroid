// Decompiled with JetBrains decompiler
// Type: ProjectM.BuffResistanceAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class BuffResistanceAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Resistances;
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726391, XrefRangeEnd = 726434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffResistanceAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe PrefabGUID PrefabGuid
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 726435, RefRangeEnd = 726444, XrefRangeStart = 726434, XrefRangeEnd = 726435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffResistanceAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuffResistanceAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffResistanceAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffResistanceAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuffResistanceAsset()
    {
      Il2CppClassPointerStore<BuffResistanceAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BuffResistanceAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffResistanceAsset>.NativeClassPtr);
      BuffResistanceAsset.NativeFieldInfoPtr_Resistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffResistanceAsset>.NativeClassPtr, nameof (Resistances));
      BuffResistanceAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffResistanceAsset>.NativeClassPtr, nameof (_Guid));
      BuffResistanceAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffResistanceAsset>.NativeClassPtr, 100664201);
      BuffResistanceAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffResistanceAsset>.NativeClassPtr, 100664202);
      BuffResistanceAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffResistanceAsset>.NativeClassPtr, 100664203);
    }

    public BuffResistanceAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BuffResistanceAsset.BuffResistanceArray Resistances
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffResistanceAsset.NativeFieldInfoPtr_Resistances));
        return pointer == IntPtr.Zero ? (BuffResistanceAsset.BuffResistanceArray) null : new BuffResistanceAsset.BuffResistanceArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffResistanceAsset.NativeFieldInfoPtr_Resistances), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffResistanceAsset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffResistanceAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [Serializable]
    public class BuffResistanceArray : ReorderableArray<BuffResistanceElement>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726388, XrefRangeEnd = 726391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BuffResistanceArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffResistanceAsset.BuffResistanceArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffResistanceAsset.BuffResistanceArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static BuffResistanceArray()
      {
        Il2CppClassPointerStore<BuffResistanceAsset.BuffResistanceArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffResistanceAsset>.NativeClassPtr, nameof (BuffResistanceArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffResistanceAsset.BuffResistanceArray>.NativeClassPtr);
        BuffResistanceAsset.BuffResistanceArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffResistanceAsset.BuffResistanceArray>.NativeClassPtr, 100664204);
      }

      public BuffResistanceArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
