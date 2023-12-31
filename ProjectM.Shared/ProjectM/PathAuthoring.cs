// Decompiled with JetBrains decompiler
// Type: ProjectM.PathAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class PathAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Looping;
    private static readonly IntPtr NativeFieldInfoPtr_PathColor;
    private static readonly IntPtr NativeFieldInfoPtr_IsVisible;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetNodes_Public_List_1_PathNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747040, XrefRangeEnd = 747125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(PathAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 747156, RefRangeEnd = 747157, XrefRangeStart = 747125, XrefRangeEnd = 747156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<PathNodeAuthoring> GetNodes()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PathAuthoring.NativeMethodInfoPtr_GetNodes_Public_List_1_PathNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (List<PathNodeAuthoring>) null : new List<PathNodeAuthoring>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747157, XrefRangeEnd = 747159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PathAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PathAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PathAuthoring()
    {
      Il2CppClassPointerStore<PathAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PathAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathAuthoring>.NativeClassPtr);
      PathAuthoring.NativeFieldInfoPtr_Looping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathAuthoring>.NativeClassPtr, nameof (Looping));
      PathAuthoring.NativeFieldInfoPtr_PathColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathAuthoring>.NativeClassPtr, nameof (PathColor));
      PathAuthoring.NativeFieldInfoPtr_IsVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathAuthoring>.NativeClassPtr, nameof (IsVisible));
      PathAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathAuthoring>.NativeClassPtr, 100665776);
      PathAuthoring.NativeMethodInfoPtr_GetNodes_Public_List_1_PathNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathAuthoring>.NativeClassPtr, 100665777);
      PathAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathAuthoring>.NativeClassPtr, 100665778);
    }

    public PathAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool Looping
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathAuthoring.NativeFieldInfoPtr_Looping));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathAuthoring.NativeFieldInfoPtr_Looping)) = value;
      }
    }

    public unsafe Color PathColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathAuthoring.NativeFieldInfoPtr_PathColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathAuthoring.NativeFieldInfoPtr_PathColor)) = value;
      }
    }

    public unsafe bool IsVisible
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathAuthoring.NativeFieldInfoPtr_IsVisible));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathAuthoring.NativeFieldInfoPtr_IsVisible)) = value;
      }
    }
  }
}
