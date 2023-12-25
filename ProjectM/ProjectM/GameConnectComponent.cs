// Decompiled with JetBrains decompiler
// Type: ProjectM.GameConnectComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class GameConnectComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ConnectString;
    private static readonly IntPtr NativeFieldInfoPtr_ShouldHost;
    private static readonly IntPtr NativeFieldInfoPtr_ServerSaveName;
    private static readonly IntPtr NativeFieldInfoPtr_HostAddress;
    private static readonly IntPtr NativeFieldInfoPtr_HostPort;
    private static readonly IntPtr NativeFieldInfoPtr_HostMaxUsers;
    private static readonly IntPtr NativeFieldInfoPtr_SceneToLoad;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978885, XrefRangeEnd = 978904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(GameConnectComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978904, XrefRangeEnd = 978914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameConnectComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameConnectComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameConnectComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameConnectComponent()
    {
      Il2CppClassPointerStore<GameConnectComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (GameConnectComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameConnectComponent>.NativeClassPtr);
      GameConnectComponent.NativeFieldInfoPtr_ConnectString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectComponent>.NativeClassPtr, nameof (ConnectString));
      GameConnectComponent.NativeFieldInfoPtr_ShouldHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectComponent>.NativeClassPtr, nameof (ShouldHost));
      GameConnectComponent.NativeFieldInfoPtr_ServerSaveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectComponent>.NativeClassPtr, nameof (ServerSaveName));
      GameConnectComponent.NativeFieldInfoPtr_HostAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectComponent>.NativeClassPtr, nameof (HostAddress));
      GameConnectComponent.NativeFieldInfoPtr_HostPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectComponent>.NativeClassPtr, nameof (HostPort));
      GameConnectComponent.NativeFieldInfoPtr_HostMaxUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectComponent>.NativeClassPtr, nameof (HostMaxUsers));
      GameConnectComponent.NativeFieldInfoPtr_SceneToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectComponent>.NativeClassPtr, nameof (SceneToLoad));
      GameConnectComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConnectComponent>.NativeClassPtr, 100675623);
      GameConnectComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConnectComponent>.NativeClassPtr, 100675624);
    }

    public GameConnectComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string ConnectString
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameConnectComponent.NativeFieldInfoPtr_ConnectString)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameConnectComponent.NativeFieldInfoPtr_ConnectString), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool ShouldHost
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameConnectComponent.NativeFieldInfoPtr_ShouldHost));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameConnectComponent.NativeFieldInfoPtr_ShouldHost)) = value;
      }
    }

    public unsafe string ServerSaveName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameConnectComponent.NativeFieldInfoPtr_ServerSaveName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameConnectComponent.NativeFieldInfoPtr_ServerSaveName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string HostAddress
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameConnectComponent.NativeFieldInfoPtr_HostAddress)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameConnectComponent.NativeFieldInfoPtr_HostAddress), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ushort HostPort
    {
      get
      {
        return *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameConnectComponent.NativeFieldInfoPtr_HostPort));
      }
      [param: In] set
      {
        *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameConnectComponent.NativeFieldInfoPtr_HostPort)) = value;
      }
    }

    public unsafe int HostMaxUsers
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameConnectComponent.NativeFieldInfoPtr_HostMaxUsers));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameConnectComponent.NativeFieldInfoPtr_HostMaxUsers)) = value;
      }
    }

    public unsafe string SceneToLoad
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameConnectComponent.NativeFieldInfoPtr_SceneToLoad)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameConnectComponent.NativeFieldInfoPtr_SceneToLoad), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
