// Decompiled with JetBrains decompiler
// Type: ProjectM.ConsoleShared
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Engine.Console;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class ConsoleShared : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetLocalUser_Public_Static_Boolean_byref_Entity_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetLocalCharacter_Public_Static_Boolean_byref_Entity_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateOrDestroySingleton_Public_Static_Void_EntityManager_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UserInfos_Public_Static_IEnumerable_1_UserInfoElement_World_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SuggestUserNames_Public_Static_Void_World_ArgumentSuggestionCollection_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UserWithNameExists_Public_Static_Boolean_World_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInfoElementOfUserWithName_Public_Static_Boolean_World_Boolean_String_byref_UserInfoElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsDebug_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEditor_Public_Static_Boolean_0;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 763847, RefRangeEnd = 763852, XrefRangeStart = 763808, XrefRangeEnd = 763847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetLocalUser(out Entity entity, World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConsoleShared.NativeMethodInfoPtr_TryGetLocalUser_Public_Static_Boolean_byref_Entity_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 763862, RefRangeEnd = 763865, XrefRangeStart = 763852, XrefRangeEnd = 763862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetLocalCharacter(out Entity entity, World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConsoleShared.NativeMethodInfoPtr_TryGetLocalCharacter_Public_Static_Boolean_byref_Entity_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 763872, RefRangeEnd = 763873, XrefRangeStart = 763865, XrefRangeEnd = 763872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateOrDestroySingleton<TSingleton>(
      EntityManager entityManager,
      bool shouldBeEnabled)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &shouldBeEnabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConsoleShared.MethodInfoStoreGeneric_CreateOrDestroySingleton_Public_Static_Void_EntityManager_Boolean_0<TSingleton>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 763878, RefRangeEnd = 763884, XrefRangeStart = 763873, XrefRangeEnd = 763878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe IEnumerable<UserInfoElement> UserInfos(World world, bool onlyConnected)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &onlyConnected;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConsoleShared.NativeMethodInfoPtr_UserInfos_Public_Static_IEnumerable_1_UserInfoElement_World_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerable<UserInfoElement>) null : new IEnumerable<UserInfoElement>(pointer);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 763902, RefRangeEnd = 763912, XrefRangeStart = 763884, XrefRangeEnd = 763902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SuggestUserNames(
      World world,
      ArgumentSuggestionCollection suggestionCollection,
      bool onlyConnected)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestionCollection);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &onlyConnected;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConsoleShared.NativeMethodInfoPtr_SuggestUserNames_Public_Static_Void_World_ArgumentSuggestionCollection_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 763928, RefRangeEnd = 763930, XrefRangeStart = 763912, XrefRangeEnd = 763928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool UserWithNameExists(World world, string name)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConsoleShared.NativeMethodInfoPtr_UserWithNameExists_Public_Static_Boolean_World_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 763946, RefRangeEnd = 763957, XrefRangeStart = 763930, XrefRangeEnd = 763946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInfoElementOfUserWithName(
      World world,
      bool onlyConnected,
      string name,
      out UserInfoElement result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &onlyConnected;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConsoleShared.NativeMethodInfoPtr_TryGetInfoElementOfUserWithName_Public_Static_Boolean_World_Boolean_String_byref_UserInfoElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1858)]
    [CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsDebug()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConsoleShared.NativeMethodInfoPtr_IsDebug_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1858)]
    [CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsEditor()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConsoleShared.NativeMethodInfoPtr_IsEditor_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ConsoleShared()
    {
      Il2CppClassPointerStore<ConsoleShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ConsoleShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleShared>.NativeClassPtr);
      ConsoleShared.NativeMethodInfoPtr_TryGetLocalUser_Public_Static_Boolean_byref_Entity_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared>.NativeClassPtr, 100667481);
      ConsoleShared.NativeMethodInfoPtr_TryGetLocalCharacter_Public_Static_Boolean_byref_Entity_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared>.NativeClassPtr, 100667482);
      ConsoleShared.NativeMethodInfoPtr_CreateOrDestroySingleton_Public_Static_Void_EntityManager_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared>.NativeClassPtr, 100667483);
      ConsoleShared.NativeMethodInfoPtr_UserInfos_Public_Static_IEnumerable_1_UserInfoElement_World_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared>.NativeClassPtr, 100667484);
      ConsoleShared.NativeMethodInfoPtr_SuggestUserNames_Public_Static_Void_World_ArgumentSuggestionCollection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared>.NativeClassPtr, 100667485);
      ConsoleShared.NativeMethodInfoPtr_UserWithNameExists_Public_Static_Boolean_World_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared>.NativeClassPtr, 100667486);
      ConsoleShared.NativeMethodInfoPtr_TryGetInfoElementOfUserWithName_Public_Static_Boolean_World_Boolean_String_byref_UserInfoElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared>.NativeClassPtr, 100667487);
      ConsoleShared.NativeMethodInfoPtr_IsDebug_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared>.NativeClassPtr, 100667488);
      ConsoleShared.NativeMethodInfoPtr_IsEditor_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared>.NativeClassPtr, 100667489);
    }

    public ConsoleShared(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("ProjectM.ConsoleShared/<UserInfos>d__3")]
    public sealed class _UserInfos_d__3 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr___l__initialThreadId;
      private static readonly System.IntPtr NativeFieldInfoPtr_world;
      private static readonly System.IntPtr NativeFieldInfoPtr___3__world;
      private static readonly System.IntPtr NativeFieldInfoPtr_onlyConnected;
      private static readonly System.IntPtr NativeFieldInfoPtr___3__onlyConnected;
      private static readonly System.IntPtr NativeFieldInfoPtr__userInfoListSingletonAccessor_5__2;
      private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_ProjectM_UserInfoElement__get_Current_Private_Virtual_Final_New_get_UserInfoElement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_UserInfoElement__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_UserInfoElement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 763742, RefRangeEnd = 763743, XrefRangeStart = 763740, XrefRangeEnd = 763742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe _UserInfos_d__3(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &_param1;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 763751, RefRangeEnd = 763752, XrefRangeStart = 763743, XrefRangeEnd = 763751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763752, XrefRangeEnd = 763786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763786, XrefRangeEnd = 763789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void __m__Finally1()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763789, XrefRangeEnd = 763792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void __m__Finally2()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe UserInfoElement System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CProjectM\u002EUserInfoElement\u003E\u002ECurrent
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_ProjectM_UserInfoElement__get_Current_Private_Virtual_Final_New_get_UserInfoElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UserInfoElement*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763792, XrefRangeEnd = 763797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763797, XrefRangeEnd = 763800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763800, XrefRangeEnd = 763808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator<UserInfoElement> System_Collections_Generic_IEnumerable_ProjectM_UserInfoElement__GetEnumerator()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_UserInfoElement__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_UserInfoElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator<UserInfoElement>) null : new IEnumerator<UserInfoElement>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
      }

      static _UserInfos_d__3()
      {
        Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConsoleShared>.NativeClassPtr, "<UserInfos>d__3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr);
        ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, "<>1__state");
        ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, "<>2__current");
        ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, "<>l__initialThreadId");
        ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr_world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, nameof (world));
        ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___3__world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, "<>3__world");
        ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr_onlyConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, nameof (onlyConnected));
        ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___3__onlyConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, "<>3__onlyConnected");
        ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr__userInfoListSingletonAccessor_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, "<userInfoListSingletonAccessor>5__2");
        ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, "<>7__wrap2");
        ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, 100667490);
        ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, 100667491);
        ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, 100667492);
        ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, 100667493);
        ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, 100667494);
        ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_ProjectM_UserInfoElement__get_Current_Private_Virtual_Final_New_get_UserInfoElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, 100667495);
        ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, 100667496);
        ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, 100667497);
        ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_UserInfoElement__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_UserInfoElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, 100667498);
        ConsoleShared._UserInfos_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleShared._UserInfos_d__3>.NativeClassPtr, 100667499);
      }

      public _UserInfos_d__3(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe UserInfoElement __2__current
      {
        get
        {
          return *(UserInfoElement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___2__current));
        }
        [param: In] set
        {
          *(UserInfoElement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___2__current)) = value;
        }
      }

      public unsafe int __l__initialThreadId
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___l__initialThreadId));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
        }
      }

      public unsafe World world
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr_world));
          return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr_world), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe World __3__world
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___3__world));
          return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___3__world), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool onlyConnected
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr_onlyConnected));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr_onlyConnected)) = value;
        }
      }

      public unsafe bool __3__onlyConnected
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___3__onlyConnected));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___3__onlyConnected)) = value;
        }
      }

      public unsafe SingletonAccessor<UserInfoBufferSingleton> _userInfoListSingletonAccessor_5__2
      {
        get
        {
          return *(SingletonAccessor<UserInfoBufferSingleton>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr__userInfoListSingletonAccessor_5__2));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr__userInfoListSingletonAccessor_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<UserInfoBufferSingleton>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeArray<UserInfoElement>.Enumerator __7__wrap2
      {
        get
        {
          return *(NativeArray<UserInfoElement>.Enumerator*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___7__wrap2));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleShared._UserInfos_d__3.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<UserInfoElement>.Enumerator>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_CreateOrDestroySingleton_Public_Static_Void_EntityManager_Boolean_0<TSingleton>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ConsoleShared.NativeMethodInfoPtr_CreateOrDestroySingleton_Public_Static_Void_EntityManager_Boolean_0, Il2CppClassPointerStore<ConsoleShared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSingleton>.NativeClassPtr))
      }))));
    }
  }
}
