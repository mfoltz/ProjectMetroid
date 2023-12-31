// Decompiled with JetBrains decompiler
// Type: ProjectM.GameplayConsoleCommandSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class GameplayConsoleCommandSystem : ConsoleCommandSystem
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetLocalUser_Protected_Boolean_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetLocalCharacter_Protected_Boolean_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSingletonExistance_Public_Static_Void_World_Boolean_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 732809, RefRangeEnd = 732826, XrefRangeStart = 732807, XrefRangeEnd = 732809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetLocalUser(out Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayConsoleCommandSystem.NativeMethodInfoPtr_TryGetLocalUser_Protected_Boolean_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 732828, RefRangeEnd = 732836, XrefRangeStart = 732826, XrefRangeEnd = 732828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetLocalCharacter(out Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayConsoleCommandSystem.NativeMethodInfoPtr_TryGetLocalCharacter_Protected_Boolean_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe void SetSingletonExistance<T>(World world, bool enable, T data = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &enable;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) data;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref data;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayConsoleCommandSystem.MethodInfoStoreGeneric_SetSingletonExistance_Public_Static_Void_World_Boolean_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 732837, RefRangeEnd = 732840, XrefRangeStart = 732836, XrefRangeEnd = 732837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameplayConsoleCommandSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayConsoleCommandSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayConsoleCommandSystem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameplayConsoleCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameplayConsoleCommandSystem()
    {
      Il2CppClassPointerStore<GameplayConsoleCommandSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameplayConsoleCommandSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayConsoleCommandSystem>.NativeClassPtr);
      GameplayConsoleCommandSystem.NativeMethodInfoPtr_TryGetLocalUser_Protected_Boolean_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayConsoleCommandSystem>.NativeClassPtr, 100664758);
      GameplayConsoleCommandSystem.NativeMethodInfoPtr_TryGetLocalCharacter_Protected_Boolean_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayConsoleCommandSystem>.NativeClassPtr, 100664759);
      GameplayConsoleCommandSystem.NativeMethodInfoPtr_SetSingletonExistance_Public_Static_Void_World_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayConsoleCommandSystem>.NativeClassPtr, 100664760);
      GameplayConsoleCommandSystem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayConsoleCommandSystem>.NativeClassPtr, 100664761);
      GameplayConsoleCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayConsoleCommandSystem>.NativeClassPtr, 100664762);
    }

    public GameplayConsoleCommandSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_SetSingletonExistance_Public_Static_Void_World_Boolean_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameplayConsoleCommandSystem.NativeMethodInfoPtr_SetSingletonExistance_Public_Static_Void_World_Boolean_T_0, Il2CppClassPointerStore<GameplayConsoleCommandSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
