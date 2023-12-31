// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileCellGameplayHeights
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileCellGameplayHeights
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_INVALID_INDEX;
    private static readonly System.IntPtr NativeFieldInfoPtr_TILE_COUNT;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompressedHeights;
    [FieldOffset(0)]
    public TileCellGameplayHeights._CompressedHeights_e__FixedBuffer CompressedHeights;

    static TileCellGameplayHeights()
    {
      Il2CppClassPointerStore<TileCellGameplayHeights>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileCellGameplayHeights));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileCellGameplayHeights>.NativeClassPtr);
      TileCellGameplayHeights.NativeFieldInfoPtr_INVALID_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCellGameplayHeights>.NativeClassPtr, nameof (INVALID_INDEX));
      TileCellGameplayHeights.NativeFieldInfoPtr_TILE_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCellGameplayHeights>.NativeClassPtr, nameof (TILE_COUNT));
      TileCellGameplayHeights.NativeFieldInfoPtr_CompressedHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCellGameplayHeights>.NativeClassPtr, nameof (CompressedHeights));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileCellGameplayHeights>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe byte INVALID_INDEX
    {
      get
      {
        byte invalidIndex;
        IL2CPP.il2cpp_field_static_get_value(TileCellGameplayHeights.NativeFieldInfoPtr_INVALID_INDEX, (void*) &invalidIndex);
        return invalidIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileCellGameplayHeights.NativeFieldInfoPtr_INVALID_INDEX, (void*) &value);
      }
    }

    public static unsafe int TILE_COUNT
    {
      get
      {
        int tileCount;
        IL2CPP.il2cpp_field_static_get_value(TileCellGameplayHeights.NativeFieldInfoPtr_TILE_COUNT, (void*) &tileCount);
        return tileCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileCellGameplayHeights.NativeFieldInfoPtr_TILE_COUNT, (void*) &value);
      }
    }

    [ObfuscatedName("ProjectM.Tiles.TileCellGameplayHeights/<CompressedHeights>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _CompressedHeights_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public ushort FixedElementField;

      static _CompressedHeights_e__FixedBuffer()
      {
        Il2CppClassPointerStore<TileCellGameplayHeights._CompressedHeights_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileCellGameplayHeights>.NativeClassPtr, "<CompressedHeights>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileCellGameplayHeights._CompressedHeights_e__FixedBuffer>.NativeClassPtr);
        TileCellGameplayHeights._CompressedHeights_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCellGameplayHeights._CompressedHeights_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileCellGameplayHeights._CompressedHeights_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
