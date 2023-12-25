// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BuildMenuUtilities
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public static class BuildMenuUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEditingPickedEntity_Internal_Static_Boolean_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectEditOptions_Internal_Static_Void_EntityManager_Entity_Entity_byref_ObjectEditOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGet_Internal_Static_Boolean_T_byref_T_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1226963, RefRangeEnd = 1226967, XrefRangeStart = 1226958, XrefRangeEnd = 1226963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsEditingPickedEntity(
      EntityManager entityManager,
      Entity localCharacter,
      Entity pickedEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pickedEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuUtilities.NativeMethodInfoPtr_IsEditingPickedEntity_Internal_Static_Boolean_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1226975, RefRangeEnd = 1226976, XrefRangeStart = 1226967, XrefRangeEnd = 1226975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetObjectEditOptions(
      EntityManager entityManager,
      Entity localControlled,
      Entity hoverBlueprintTarget,
      out BuildMenuUtilities.ObjectEditOptions editOptions)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localControlled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hoverBlueprintTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref editOptions;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuUtilities.NativeMethodInfoPtr_GetObjectEditOptions_Internal_Static_Void_EntityManager_Entity_Entity_byref_ObjectEditOptions_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1226977, RefRangeEnd = 1226981, XrefRangeStart = 1226976, XrefRangeEnd = 1226977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGet<T>(T value, out T result) where T : class
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local3;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local3 = ref (*(T*) &zero);
      }
      else
        local3 = ref result;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BuildMenuUtilities.MethodInfoStoreGeneric_TryGet_Internal_Static_Boolean_T_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local4 = ref result;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local4 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    static BuildMenuUtilities()
    {
      Il2CppClassPointerStore<BuildMenuUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BuildMenuUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuUtilities>.NativeClassPtr);
      BuildMenuUtilities.NativeMethodInfoPtr_IsEditingPickedEntity_Internal_Static_Boolean_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuUtilities>.NativeClassPtr, 100665024);
      BuildMenuUtilities.NativeMethodInfoPtr_GetObjectEditOptions_Internal_Static_Void_EntityManager_Entity_Entity_byref_ObjectEditOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuUtilities>.NativeClassPtr, 100665025);
      BuildMenuUtilities.NativeMethodInfoPtr_TryGet_Internal_Static_Boolean_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuUtilities>.NativeClassPtr, 100665026);
    }

    public BuildMenuUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ObjectEditOptions
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CanMove;
      private static readonly System.IntPtr NativeFieldInfoPtr_CanRotate;
      private static readonly System.IntPtr NativeFieldInfoPtr_CanSelect;
      private static readonly System.IntPtr NativeFieldInfoPtr_CanDismantle;
      private static readonly System.IntPtr NativeFieldInfoPtr_CanRepair;
      [FieldOffset(0)]
      public bool CanMove;
      [FieldOffset(1)]
      public bool CanRotate;
      [FieldOffset(2)]
      public bool CanSelect;
      [FieldOffset(3)]
      public bool CanDismantle;
      [FieldOffset(4)]
      public bool CanRepair;

      static ObjectEditOptions()
      {
        Il2CppClassPointerStore<BuildMenuUtilities.ObjectEditOptions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuUtilities>.NativeClassPtr, nameof (ObjectEditOptions));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuUtilities.ObjectEditOptions>.NativeClassPtr);
        BuildMenuUtilities.ObjectEditOptions.NativeFieldInfoPtr_CanMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuUtilities.ObjectEditOptions>.NativeClassPtr, nameof (CanMove));
        BuildMenuUtilities.ObjectEditOptions.NativeFieldInfoPtr_CanRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuUtilities.ObjectEditOptions>.NativeClassPtr, nameof (CanRotate));
        BuildMenuUtilities.ObjectEditOptions.NativeFieldInfoPtr_CanSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuUtilities.ObjectEditOptions>.NativeClassPtr, nameof (CanSelect));
        BuildMenuUtilities.ObjectEditOptions.NativeFieldInfoPtr_CanDismantle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuUtilities.ObjectEditOptions>.NativeClassPtr, nameof (CanDismantle));
        BuildMenuUtilities.ObjectEditOptions.NativeFieldInfoPtr_CanRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuUtilities.ObjectEditOptions>.NativeClassPtr, nameof (CanRepair));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuUtilities.ObjectEditOptions>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    private sealed class MethodInfoStoreGeneric_TryGet_Internal_Static_Boolean_T_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BuildMenuUtilities.NativeMethodInfoPtr_TryGet_Internal_Static_Boolean_T_byref_T_0, Il2CppClassPointerStore<BuildMenuUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
