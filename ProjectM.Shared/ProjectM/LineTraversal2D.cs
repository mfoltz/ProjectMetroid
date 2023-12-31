// Decompiled with JetBrains decompiler
// Type: ProjectM.LineTraversal2D
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LineTraversal2D
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_ITERATIONS;
    private static readonly System.IntPtr NativeFieldInfoPtr_iterations;
    private static readonly System.IntPtr NativeFieldInfoPtr_ty;
    private static readonly System.IntPtr NativeFieldInfoPtr_tx;
    private static readonly System.IntPtr NativeFieldInfoPtr_deltatx;
    private static readonly System.IntPtr NativeFieldInfoPtr_deltaty;
    private static readonly System.IntPtr NativeFieldInfoPtr_di;
    private static readonly System.IntPtr NativeFieldInfoPtr_dj;
    private static readonly System.IntPtr NativeFieldInfoPtr_i;
    private static readonly System.IntPtr NativeFieldInfoPtr_j;
    private static readonly System.IntPtr NativeFieldInfoPtr_iend;
    private static readonly System.IntPtr NativeFieldInfoPtr_jend;
    private static readonly System.IntPtr NativeFieldInfoPtr_distance;
    private static readonly System.IntPtr NativeFieldInfoPtr__GridSizeX;
    private static readonly System.IntPtr NativeFieldInfoPtr__GridSizeY;
    private static readonly System.IntPtr NativeFieldInfoPtr__CellSize;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_X_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Y_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_XY_Public_get_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TX_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TY_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Percent_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeTraversal_Public_Void_Single_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTraversal_Public_Boolean_0;
    [FieldOffset(0)]
    public int iterations;
    [FieldOffset(4)]
    public float ty;
    [FieldOffset(8)]
    public float tx;
    [FieldOffset(12)]
    public float deltatx;
    [FieldOffset(16)]
    public float deltaty;
    [FieldOffset(20)]
    public int di;
    [FieldOffset(24)]
    public int dj;
    [FieldOffset(28)]
    public int i;
    [FieldOffset(32)]
    public int j;
    [FieldOffset(36)]
    public int iend;
    [FieldOffset(40)]
    public int jend;
    [FieldOffset(44)]
    public float distance;
    [FieldOffset(48)]
    public int _GridSizeX;
    [FieldOffset(52)]
    public int _GridSizeY;
    [FieldOffset(56)]
    public float _CellSize;

    public unsafe int X
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 40254, RefRangeEnd = 40255, XrefRangeStart = 40254, XrefRangeEnd = 40255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LineTraversal2D.NativeMethodInfoPtr_get_X_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int Y
    {
      [CallerCount(36), CachedScanResults(RefRangeStart = 29682, RefRangeEnd = 29718, XrefRangeStart = 29682, XrefRangeEnd = 29718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LineTraversal2D.NativeMethodInfoPtr_get_Y_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int2 XY
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 764910, RefRangeEnd = 764917, XrefRangeStart = 764910, XrefRangeEnd = 764910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LineTraversal2D.NativeMethodInfoPtr_get_XY_Public_get_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int2*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float TX
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LineTraversal2D.NativeMethodInfoPtr_get_TX_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float TY
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LineTraversal2D.NativeMethodInfoPtr_get_TY_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float Percent
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 764918, RefRangeEnd = 764919, XrefRangeStart = 764917, XrefRangeEnd = 764918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LineTraversal2D.NativeMethodInfoPtr_get_Percent_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 764925, RefRangeEnd = 764930, XrefRangeStart = 764919, XrefRangeEnd = 764925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LineTraversal2D(float cellSize, int gridSizeX, int gridSizeY)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &cellSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gridSizeX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &gridSizeY;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LineTraversal2D.NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 764943, RefRangeEnd = 764950, XrefRangeStart = 764930, XrefRangeEnd = 764943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeTraversal(float x1, float x2, float y1, float y2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &x1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &x2;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &y1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &y2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LineTraversal2D.NativeMethodInfoPtr_InitializeTraversal_Public_Void_Single_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 764955, RefRangeEnd = 764960, XrefRangeStart = 764950, XrefRangeEnd = 764955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool UpdateTraversal()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LineTraversal2D.NativeMethodInfoPtr_UpdateTraversal_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static LineTraversal2D()
    {
      Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (LineTraversal2D));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr);
      LineTraversal2D.NativeFieldInfoPtr_MAX_ITERATIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, nameof (MAX_ITERATIONS));
      LineTraversal2D.NativeFieldInfoPtr_iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, nameof (iterations));
      LineTraversal2D.NativeFieldInfoPtr_ty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, nameof (ty));
      LineTraversal2D.NativeFieldInfoPtr_tx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, nameof (tx));
      LineTraversal2D.NativeFieldInfoPtr_deltatx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, nameof (deltatx));
      LineTraversal2D.NativeFieldInfoPtr_deltaty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, nameof (deltaty));
      LineTraversal2D.NativeFieldInfoPtr_di = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, nameof (di));
      LineTraversal2D.NativeFieldInfoPtr_dj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, nameof (dj));
      LineTraversal2D.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, nameof (i));
      LineTraversal2D.NativeFieldInfoPtr_j = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, nameof (j));
      LineTraversal2D.NativeFieldInfoPtr_iend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, nameof (iend));
      LineTraversal2D.NativeFieldInfoPtr_jend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, nameof (jend));
      LineTraversal2D.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, nameof (distance));
      LineTraversal2D.NativeFieldInfoPtr__GridSizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, nameof (_GridSizeX));
      LineTraversal2D.NativeFieldInfoPtr__GridSizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, nameof (_GridSizeY));
      LineTraversal2D.NativeFieldInfoPtr__CellSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, nameof (_CellSize));
      LineTraversal2D.NativeMethodInfoPtr_get_X_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, 100667549);
      LineTraversal2D.NativeMethodInfoPtr_get_Y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, 100667550);
      LineTraversal2D.NativeMethodInfoPtr_get_XY_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, 100667551);
      LineTraversal2D.NativeMethodInfoPtr_get_TX_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, 100667552);
      LineTraversal2D.NativeMethodInfoPtr_get_TY_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, 100667553);
      LineTraversal2D.NativeMethodInfoPtr_get_Percent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, 100667554);
      LineTraversal2D.NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, 100667555);
      LineTraversal2D.NativeMethodInfoPtr_InitializeTraversal_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, 100667556);
      LineTraversal2D.NativeMethodInfoPtr_UpdateTraversal_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, 100667557);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LineTraversal2D>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int MAX_ITERATIONS
    {
      get
      {
        int maxIterations;
        IL2CPP.il2cpp_field_static_get_value(LineTraversal2D.NativeFieldInfoPtr_MAX_ITERATIONS, (void*) &maxIterations);
        return maxIterations;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LineTraversal2D.NativeFieldInfoPtr_MAX_ITERATIONS, (void*) &value);
      }
    }
  }
}
