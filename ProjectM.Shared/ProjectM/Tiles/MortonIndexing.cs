// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.MortonIndexing
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  public static class MortonIndexing : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Index_0_0;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index_1_0;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index_0_1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index_1_1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index_2_0;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index_3_0;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index_2_1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index_3_1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index_0_2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index_1_2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index_0_3;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index_1_3;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index_2_2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index_3_2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index_2_3;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index_3_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIndex_Public_Static_Int16_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIndex_Public_Static_Int16_Byte_Byte_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 791715, RefRangeEnd = 791718, XrefRangeStart = 791715, XrefRangeEnd = 791715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe short GetIndex(int2 coord)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &coord;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MortonIndexing.NativeMethodInfoPtr_GetIndex_Public_Static_Int16_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(short*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 791718, RefRangeEnd = 791720, XrefRangeStart = 791718, XrefRangeEnd = 791718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe short GetIndex(byte x, byte y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MortonIndexing.NativeMethodInfoPtr_GetIndex_Public_Static_Int16_Byte_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(short*) IL2CPP.il2cpp_object_unbox(num);
    }

    static MortonIndexing()
    {
      Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (MortonIndexing));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr);
      MortonIndexing.NativeFieldInfoPtr_Index_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, nameof (Index_0_0));
      MortonIndexing.NativeFieldInfoPtr_Index_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, nameof (Index_1_0));
      MortonIndexing.NativeFieldInfoPtr_Index_0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, nameof (Index_0_1));
      MortonIndexing.NativeFieldInfoPtr_Index_1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, nameof (Index_1_1));
      MortonIndexing.NativeFieldInfoPtr_Index_2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, nameof (Index_2_0));
      MortonIndexing.NativeFieldInfoPtr_Index_3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, nameof (Index_3_0));
      MortonIndexing.NativeFieldInfoPtr_Index_2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, nameof (Index_2_1));
      MortonIndexing.NativeFieldInfoPtr_Index_3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, nameof (Index_3_1));
      MortonIndexing.NativeFieldInfoPtr_Index_0_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, nameof (Index_0_2));
      MortonIndexing.NativeFieldInfoPtr_Index_1_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, nameof (Index_1_2));
      MortonIndexing.NativeFieldInfoPtr_Index_0_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, nameof (Index_0_3));
      MortonIndexing.NativeFieldInfoPtr_Index_1_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, nameof (Index_1_3));
      MortonIndexing.NativeFieldInfoPtr_Index_2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, nameof (Index_2_2));
      MortonIndexing.NativeFieldInfoPtr_Index_3_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, nameof (Index_3_2));
      MortonIndexing.NativeFieldInfoPtr_Index_2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, nameof (Index_2_3));
      MortonIndexing.NativeFieldInfoPtr_Index_3_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, nameof (Index_3_3));
      MortonIndexing.NativeMethodInfoPtr_GetIndex_Public_Static_Int16_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, 100669649);
      MortonIndexing.NativeMethodInfoPtr_GetIndex_Public_Static_Int16_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MortonIndexing>.NativeClassPtr, 100669650);
    }

    public MortonIndexing(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe short Index_0_0
    {
      get
      {
        short index00;
        IL2CPP.il2cpp_field_static_get_value(MortonIndexing.NativeFieldInfoPtr_Index_0_0, (void*) &index00);
        return index00;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MortonIndexing.NativeFieldInfoPtr_Index_0_0, (void*) &value);
      }
    }

    public static unsafe short Index_1_0
    {
      get
      {
        short index10;
        IL2CPP.il2cpp_field_static_get_value(MortonIndexing.NativeFieldInfoPtr_Index_1_0, (void*) &index10);
        return index10;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MortonIndexing.NativeFieldInfoPtr_Index_1_0, (void*) &value);
      }
    }

    public static unsafe short Index_0_1
    {
      get
      {
        short index01;
        IL2CPP.il2cpp_field_static_get_value(MortonIndexing.NativeFieldInfoPtr_Index_0_1, (void*) &index01);
        return index01;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MortonIndexing.NativeFieldInfoPtr_Index_0_1, (void*) &value);
      }
    }

    public static unsafe short Index_1_1
    {
      get
      {
        short index11;
        IL2CPP.il2cpp_field_static_get_value(MortonIndexing.NativeFieldInfoPtr_Index_1_1, (void*) &index11);
        return index11;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MortonIndexing.NativeFieldInfoPtr_Index_1_1, (void*) &value);
      }
    }

    public static unsafe short Index_2_0
    {
      get
      {
        short index20;
        IL2CPP.il2cpp_field_static_get_value(MortonIndexing.NativeFieldInfoPtr_Index_2_0, (void*) &index20);
        return index20;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MortonIndexing.NativeFieldInfoPtr_Index_2_0, (void*) &value);
      }
    }

    public static unsafe short Index_3_0
    {
      get
      {
        short index30;
        IL2CPP.il2cpp_field_static_get_value(MortonIndexing.NativeFieldInfoPtr_Index_3_0, (void*) &index30);
        return index30;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MortonIndexing.NativeFieldInfoPtr_Index_3_0, (void*) &value);
      }
    }

    public static unsafe short Index_2_1
    {
      get
      {
        short index21;
        IL2CPP.il2cpp_field_static_get_value(MortonIndexing.NativeFieldInfoPtr_Index_2_1, (void*) &index21);
        return index21;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MortonIndexing.NativeFieldInfoPtr_Index_2_1, (void*) &value);
      }
    }

    public static unsafe short Index_3_1
    {
      get
      {
        short index31;
        IL2CPP.il2cpp_field_static_get_value(MortonIndexing.NativeFieldInfoPtr_Index_3_1, (void*) &index31);
        return index31;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MortonIndexing.NativeFieldInfoPtr_Index_3_1, (void*) &value);
      }
    }

    public static unsafe short Index_0_2
    {
      get
      {
        short index02;
        IL2CPP.il2cpp_field_static_get_value(MortonIndexing.NativeFieldInfoPtr_Index_0_2, (void*) &index02);
        return index02;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MortonIndexing.NativeFieldInfoPtr_Index_0_2, (void*) &value);
      }
    }

    public static unsafe short Index_1_2
    {
      get
      {
        short index12;
        IL2CPP.il2cpp_field_static_get_value(MortonIndexing.NativeFieldInfoPtr_Index_1_2, (void*) &index12);
        return index12;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MortonIndexing.NativeFieldInfoPtr_Index_1_2, (void*) &value);
      }
    }

    public static unsafe short Index_0_3
    {
      get
      {
        short index03;
        IL2CPP.il2cpp_field_static_get_value(MortonIndexing.NativeFieldInfoPtr_Index_0_3, (void*) &index03);
        return index03;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MortonIndexing.NativeFieldInfoPtr_Index_0_3, (void*) &value);
      }
    }

    public static unsafe short Index_1_3
    {
      get
      {
        short index13;
        IL2CPP.il2cpp_field_static_get_value(MortonIndexing.NativeFieldInfoPtr_Index_1_3, (void*) &index13);
        return index13;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MortonIndexing.NativeFieldInfoPtr_Index_1_3, (void*) &value);
      }
    }

    public static unsafe short Index_2_2
    {
      get
      {
        short index22;
        IL2CPP.il2cpp_field_static_get_value(MortonIndexing.NativeFieldInfoPtr_Index_2_2, (void*) &index22);
        return index22;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MortonIndexing.NativeFieldInfoPtr_Index_2_2, (void*) &value);
      }
    }

    public static unsafe short Index_3_2
    {
      get
      {
        short index32;
        IL2CPP.il2cpp_field_static_get_value(MortonIndexing.NativeFieldInfoPtr_Index_3_2, (void*) &index32);
        return index32;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MortonIndexing.NativeFieldInfoPtr_Index_3_2, (void*) &value);
      }
    }

    public static unsafe short Index_2_3
    {
      get
      {
        short index23;
        IL2CPP.il2cpp_field_static_get_value(MortonIndexing.NativeFieldInfoPtr_Index_2_3, (void*) &index23);
        return index23;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MortonIndexing.NativeFieldInfoPtr_Index_2_3, (void*) &value);
      }
    }

    public static unsafe short Index_3_3
    {
      get
      {
        short index33;
        IL2CPP.il2cpp_field_static_get_value(MortonIndexing.NativeFieldInfoPtr_Index_3_3, (void*) &index33);
        return index33;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MortonIndexing.NativeFieldInfoPtr_Index_3_3, (void*) &value);
      }
    }
  }
}
