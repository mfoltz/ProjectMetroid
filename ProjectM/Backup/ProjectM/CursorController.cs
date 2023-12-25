// Decompiled with JetBrains decompiler
// Type: ProjectM.CursorController
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class CursorController : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CursorType;
    private static readonly System.IntPtr NativeFieldInfoPtr__CursorDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__WasLocked;
    private static readonly System.IntPtr NativeFieldInfoPtr__LockCursorPosition;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCursorPos_Private_Static_Int64_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCursorPos_Private_Static_Boolean_byref_CursorPosition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CursorType_Public_Static_get_CursorType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Static_Void_CursorType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Register_Public_Static_Void_Il2CppReferenceArray_1_CursorData_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007382, XrefRangeEnd = 1007384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe long SetCursorPos(int x, int y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CursorController.NativeMethodInfoPtr_SetCursorPos_Private_Static_Int64_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(long*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007384, XrefRangeEnd = 1007386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetCursorPos(out CursorController.CursorPosition lpPoint)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref lpPoint;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CursorController.NativeMethodInfoPtr_GetCursorPos_Private_Static_Boolean_byref_CursorPosition_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public static unsafe CursorType CursorType
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007386, XrefRangeEnd = 1007388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CursorController.NativeMethodInfoPtr_get_CursorType_Public_Static_get_CursorType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CursorType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1007416, RefRangeEnd = 1007417, XrefRangeStart = 1007388, XrefRangeEnd = 1007416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set(CursorType type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &type;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CursorController.NativeMethodInfoPtr_Set_Public_Static_Void_CursorType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007417, XrefRangeEnd = 1007420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Register(Il2CppReferenceArray<CursorData> cursorDatas)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cursorDatas);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CursorController.NativeMethodInfoPtr_Register_Public_Static_Void_Il2CppReferenceArray_1_CursorData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CursorController()
    {
      Il2CppClassPointerStore<CursorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CursorController));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorController>.NativeClassPtr);
      CursorController.NativeFieldInfoPtr__CursorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorController>.NativeClassPtr, nameof (_CursorType));
      CursorController.NativeFieldInfoPtr__CursorDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorController>.NativeClassPtr, nameof (_CursorDatas));
      CursorController.NativeFieldInfoPtr__WasLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorController>.NativeClassPtr, nameof (_WasLocked));
      CursorController.NativeFieldInfoPtr__LockCursorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorController>.NativeClassPtr, nameof (_LockCursorPosition));
      CursorController.NativeMethodInfoPtr_SetCursorPos_Private_Static_Int64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorController>.NativeClassPtr, 100678181);
      CursorController.NativeMethodInfoPtr_GetCursorPos_Private_Static_Boolean_byref_CursorPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorController>.NativeClassPtr, 100678182);
      CursorController.NativeMethodInfoPtr_get_CursorType_Public_Static_get_CursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorController>.NativeClassPtr, 100678183);
      CursorController.NativeMethodInfoPtr_Set_Public_Static_Void_CursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorController>.NativeClassPtr, 100678184);
      CursorController.NativeMethodInfoPtr_Register_Public_Static_Void_Il2CppReferenceArray_1_CursorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorController>.NativeClassPtr, 100678185);
    }

    public CursorController(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe CursorType _CursorType
    {
      get
      {
        CursorType cursorType;
        IL2CPP.il2cpp_field_static_get_value(CursorController.NativeFieldInfoPtr__CursorType, (void*) &cursorType);
        return cursorType;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CursorController.NativeFieldInfoPtr__CursorType, (void*) &value);
      }
    }

    public static unsafe Il2CppReferenceArray<CursorData> _CursorDatas
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CursorController.NativeFieldInfoPtr__CursorDatas, (void*) &num);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CursorData>) null : new Il2CppReferenceArray<CursorData>(nativeObject);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CursorController.NativeFieldInfoPtr__CursorDatas, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe bool _WasLocked
    {
      get
      {
        bool wasLocked;
        IL2CPP.il2cpp_field_static_get_value(CursorController.NativeFieldInfoPtr__WasLocked, (void*) &wasLocked);
        return wasLocked;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CursorController.NativeFieldInfoPtr__WasLocked, (void*) &value);
      }
    }

    public static unsafe CursorController.CursorPosition _LockCursorPosition
    {
      get
      {
        CursorController.CursorPosition lockCursorPosition;
        IL2CPP.il2cpp_field_static_get_value(CursorController.NativeFieldInfoPtr__LockCursorPosition, (void*) &lockCursorPosition);
        return lockCursorPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CursorController.NativeFieldInfoPtr__LockCursorPosition, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CursorPosition
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_X;
      private static readonly System.IntPtr NativeFieldInfoPtr_Y;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
      [FieldOffset(0)]
      public int X;
      [FieldOffset(4)]
      public int Y;

      [CallerCount(57)]
      [CachedScanResults(RefRangeStart = 56553, RefRangeEnd = 56610, XrefRangeStart = 56553, XrefRangeEnd = 56610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CursorPosition(int x, int y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CursorController.CursorPosition.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CursorPosition()
      {
        Il2CppClassPointerStore<CursorController.CursorPosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CursorController>.NativeClassPtr, nameof (CursorPosition));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorController.CursorPosition>.NativeClassPtr);
        CursorController.CursorPosition.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorController.CursorPosition>.NativeClassPtr, nameof (X));
        CursorController.CursorPosition.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorController.CursorPosition>.NativeClassPtr, nameof (Y));
        CursorController.CursorPosition.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorController.CursorPosition>.NativeClassPtr, 100678186);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CursorController.CursorPosition>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
