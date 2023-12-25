// Decompiled with JetBrains decompiler
// Type: ProjectM.ClientWorldManager
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.Auth;
using Steamworks;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ClientWorldManager : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__GameBootstrap;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientWorlds;
    private static readonly System.IntPtr NativeFieldInfoPtr__SteamPlatform;
    private static readonly System.IntPtr NativeFieldInfoPtr__EOSPlatform;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientWorldCount_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveClientWorld_Public_get_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeGameBootstrap_Public_Void_GameBootstrap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyClientWorlds_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginCreateClientWorlds_Public_Void_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateWorld_Private_CustomWorld_IReadOnlyList_1_Type_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddOrUpdatePhysicsSingleton_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe int ClientWorldCount
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 978652, RefRangeEnd = 978654, XrefRangeStart = 978652, XrefRangeEnd = 978652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientWorldManager.NativeMethodInfoPtr_get_ClientWorldCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe World ActiveClientWorld
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 978661, RefRangeEnd = 978669, XrefRangeStart = 978654, XrefRangeEnd = 978661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientWorldManager.NativeMethodInfoPtr_get_ActiveClientWorld_Public_get_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeGameBootstrap(GameBootstrap gameBootstrap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameBootstrap);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientWorldManager.NativeMethodInfoPtr_InitializeGameBootstrap_Public_Void_GameBootstrap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978669, XrefRangeEnd = 978680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientWorldManager.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978680, XrefRangeEnd = 978681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientWorldManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 978691, RefRangeEnd = 978700, XrefRangeStart = 978681, XrefRangeEnd = 978691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DestroyClientWorlds()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientWorldManager.NativeMethodInfoPtr_DestroyClientWorlds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 978825, RefRangeEnd = 978829, XrefRangeStart = 978700, XrefRangeEnd = 978825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BeginCreateClientWorlds(int numClientWorlds, bool canAutoConnect)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &numClientWorlds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &canAutoConnect;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientWorldManager.NativeMethodInfoPtr_BeginCreateClientWorlds_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 978859, RefRangeEnd = 978861, XrefRangeStart = 978829, XrefRangeEnd = 978859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomWorld CreateWorld(IReadOnlyList<Il2CppSystem.Type> allSystems, int i)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) allSystems);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &i;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientWorldManager.NativeMethodInfoPtr_CreateWorld_Private_CustomWorld_IReadOnlyList_1_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CustomWorld) null : new CustomWorld(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978861, XrefRangeEnd = 978867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientWorldManager.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978867, XrefRangeEnd = 978879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddOrUpdatePhysicsSingleton()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientWorldManager.NativeMethodInfoPtr_AddOrUpdatePhysicsSingleton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978879, XrefRangeEnd = 978884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClientWorldManager()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientWorldManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientWorldManager.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClientWorldManager()
    {
      Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ClientWorldManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr);
      ClientWorldManager.NativeFieldInfoPtr__GameBootstrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, nameof (_GameBootstrap));
      ClientWorldManager.NativeFieldInfoPtr_ClientWorlds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, nameof (ClientWorlds));
      ClientWorldManager.NativeFieldInfoPtr__SteamPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, nameof (_SteamPlatform));
      ClientWorldManager.NativeFieldInfoPtr__EOSPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, nameof (_EOSPlatform));
      ClientWorldManager.NativeMethodInfoPtr_get_ClientWorldCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, 100675605);
      ClientWorldManager.NativeMethodInfoPtr_get_ActiveClientWorld_Public_get_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, 100675606);
      ClientWorldManager.NativeMethodInfoPtr_InitializeGameBootstrap_Public_Void_GameBootstrap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, 100675607);
      ClientWorldManager.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, 100675608);
      ClientWorldManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, 100675609);
      ClientWorldManager.NativeMethodInfoPtr_DestroyClientWorlds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, 100675610);
      ClientWorldManager.NativeMethodInfoPtr_BeginCreateClientWorlds_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, 100675611);
      ClientWorldManager.NativeMethodInfoPtr_CreateWorld_Private_CustomWorld_IReadOnlyList_1_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, 100675612);
      ClientWorldManager.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, 100675613);
      ClientWorldManager.NativeMethodInfoPtr_AddOrUpdatePhysicsSingleton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, 100675614);
      ClientWorldManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, 100675615);
      ClientWorldManager.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, 100675616);
    }

    public ClientWorldManager(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameBootstrap _GameBootstrap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.NativeFieldInfoPtr__GameBootstrap));
        return pointer == System.IntPtr.Zero ? (GameBootstrap) null : new GameBootstrap(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.NativeFieldInfoPtr__GameBootstrap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<CustomWorld> ClientWorlds
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.NativeFieldInfoPtr_ClientWorlds));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CustomWorld>) null : new Il2CppReferenceArray<CustomWorld>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.NativeFieldInfoPtr_ClientWorlds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SteamPlatformSystem _SteamPlatform
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.NativeFieldInfoPtr__SteamPlatform));
        return pointer == System.IntPtr.Zero ? (SteamPlatformSystem) null : new SteamPlatformSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.NativeFieldInfoPtr__SteamPlatform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EOSPlatformSystem _EOSPlatform
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.NativeFieldInfoPtr__EOSPlatform));
        return pointer == System.IntPtr.Zero ? (EOSPlatformSystem) null : new EOSPlatformSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.NativeFieldInfoPtr__EOSPlatform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.ClientWorldManager/<>c__DisplayClass12_0")]
    public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_connectAddress;
      private static readonly System.IntPtr NativeFieldInfoPtr_password;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass12_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientWorldManager.__c__DisplayClass12_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientWorldManager.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass12_0()
      {
        Il2CppClassPointerStore<ClientWorldManager.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, "<>c__DisplayClass12_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientWorldManager.__c__DisplayClass12_0>.NativeClassPtr);
        ClientWorldManager.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWorldManager.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
        ClientWorldManager.__c__DisplayClass12_0.NativeFieldInfoPtr_connectAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWorldManager.__c__DisplayClass12_0>.NativeClassPtr, nameof (connectAddress));
        ClientWorldManager.__c__DisplayClass12_0.NativeFieldInfoPtr_password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWorldManager.__c__DisplayClass12_0>.NativeClassPtr, nameof (password));
        ClientWorldManager.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWorldManager.__c__DisplayClass12_0>.NativeClassPtr, 100675617);
      }

      public __c__DisplayClass12_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe ClientWorldManager __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ClientWorldManager) null : new ClientWorldManager(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ConnectAddress connectAddress
      {
        get
        {
          return *(ConnectAddress*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.__c__DisplayClass12_0.NativeFieldInfoPtr_connectAddress));
        }
        [param: In] set
        {
          *(ConnectAddress*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.__c__DisplayClass12_0.NativeFieldInfoPtr_connectAddress)) = value;
        }
      }

      public unsafe string password
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.__c__DisplayClass12_0.NativeFieldInfoPtr_password)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.__c__DisplayClass12_0.NativeFieldInfoPtr_password), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientWorldManager/<>c__DisplayClass12_1")]
    public sealed class __c__DisplayClass12_1 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_clientWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__BeginCreateClientWorlds_b__0_Internal_Void_Boolean_EResult_Il2CppStructArray_1_Byte_CSteamID_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass12_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientWorldManager.__c__DisplayClass12_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientWorldManager.__c__DisplayClass12_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978619, XrefRangeEnd = 978652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _BeginCreateClientWorlds_b__0(
        bool success,
        EResult result,
        Il2CppStructArray<byte> authSesionTicket,
        CSteamID userId)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &success;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) authSesionTicket);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &userId;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientWorldManager.__c__DisplayClass12_1.NativeMethodInfoPtr__BeginCreateClientWorlds_b__0_Internal_Void_Boolean_EResult_Il2CppStructArray_1_Byte_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass12_1()
      {
        Il2CppClassPointerStore<ClientWorldManager.__c__DisplayClass12_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientWorldManager>.NativeClassPtr, "<>c__DisplayClass12_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientWorldManager.__c__DisplayClass12_1>.NativeClassPtr);
        ClientWorldManager.__c__DisplayClass12_1.NativeFieldInfoPtr_clientWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWorldManager.__c__DisplayClass12_1>.NativeClassPtr, nameof (clientWorld));
        ClientWorldManager.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWorldManager.__c__DisplayClass12_1>.NativeClassPtr, "CS$<>8__locals1");
        ClientWorldManager.__c__DisplayClass12_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWorldManager.__c__DisplayClass12_1>.NativeClassPtr, 100675618);
        ClientWorldManager.__c__DisplayClass12_1.NativeMethodInfoPtr__BeginCreateClientWorlds_b__0_Internal_Void_Boolean_EResult_Il2CppStructArray_1_Byte_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWorldManager.__c__DisplayClass12_1>.NativeClassPtr, 100675619);
      }

      public __c__DisplayClass12_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe World clientWorld
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.__c__DisplayClass12_1.NativeFieldInfoPtr_clientWorld));
          return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.__c__DisplayClass12_1.NativeFieldInfoPtr_clientWorld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ClientWorldManager.__c__DisplayClass12_0 field_Public___c__DisplayClass12_0_0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0));
          return pointer == System.IntPtr.Zero ? (ClientWorldManager.__c__DisplayClass12_0) null : new ClientWorldManager.__c__DisplayClass12_0(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientWorldManager.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
