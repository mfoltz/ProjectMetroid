// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileLayerUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  public class TileLayerUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CellBasedFlagCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_StandardLayerFlagCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapCollisionFlagCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_LineOfSightFlagCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeightLevelOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinHeightLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHeightLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeightLevelRange;
    private static readonly System.IntPtr NativeMethodInfoPtr_AssertTileLayerUtilityConfiguration_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AssertCorrectFlagCount_Private_Static_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeightLevel_Public_Static_Byte_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeightForLevel_Public_Static_Single_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeightForLevelWithOffset_Public_Static_Single_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 792435, RefRangeEnd = 792436, XrefRangeStart = 792423, XrefRangeEnd = 792435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AssertTileLayerUtilityConfiguration()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileLayerUtility.NativeMethodInfoPtr_AssertTileLayerUtilityConfiguration_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 792452, RefRangeEnd = 792456, XrefRangeStart = 792436, XrefRangeEnd = 792452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AssertCorrectFlagCount<TEnum>(int expectedBitCount) where TEnum : Il2CppSystem.Enum
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &expectedBitCount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileLayerUtility.MethodInfoStoreGeneric_AssertCorrectFlagCount_Private_Static_Void_Int32_0<TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(84)]
    [CachedScanResults(RefRangeStart = 792458, RefRangeEnd = 792542, XrefRangeStart = 792456, XrefRangeEnd = 792458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe byte GetHeightLevel(float height)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &height;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerUtility.NativeMethodInfoPtr_GetHeightLevel_Public_Static_Byte_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(18)]
    [CachedScanResults(RefRangeStart = 792542, RefRangeEnd = 792560, XrefRangeStart = 792542, XrefRangeEnd = 792542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetHeightForLevel(byte heightLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &heightLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerUtility.NativeMethodInfoPtr_GetHeightForLevel_Public_Static_Single_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(26)]
    [CachedScanResults(RefRangeStart = 792560, RefRangeEnd = 792586, XrefRangeStart = 792560, XrefRangeEnd = 792560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetHeightForLevelWithOffset(byte heightLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &heightLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerUtility.NativeMethodInfoPtr_GetHeightForLevelWithOffset_Public_Static_Single_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileLayerUtility()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileLayerUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileLayerUtility()
    {
      Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileLayerUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr);
      TileLayerUtility.NativeFieldInfoPtr_CellBasedFlagCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr, nameof (CellBasedFlagCount));
      TileLayerUtility.NativeFieldInfoPtr_StandardLayerFlagCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr, nameof (StandardLayerFlagCount));
      TileLayerUtility.NativeFieldInfoPtr_MapCollisionFlagCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr, nameof (MapCollisionFlagCount));
      TileLayerUtility.NativeFieldInfoPtr_LineOfSightFlagCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr, nameof (LineOfSightFlagCount));
      TileLayerUtility.NativeFieldInfoPtr_HeightLevelOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr, nameof (HeightLevelOffset));
      TileLayerUtility.NativeFieldInfoPtr_MinHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr, nameof (MinHeightLevel));
      TileLayerUtility.NativeFieldInfoPtr_MaxHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr, nameof (MaxHeightLevel));
      TileLayerUtility.NativeFieldInfoPtr_HeightLevelRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr, nameof (HeightLevelRange));
      TileLayerUtility.NativeMethodInfoPtr_AssertTileLayerUtilityConfiguration_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr, 100669777);
      TileLayerUtility.NativeMethodInfoPtr_AssertCorrectFlagCount_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr, 100669778);
      TileLayerUtility.NativeMethodInfoPtr_GetHeightLevel_Public_Static_Byte_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr, 100669779);
      TileLayerUtility.NativeMethodInfoPtr_GetHeightForLevel_Public_Static_Single_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr, 100669780);
      TileLayerUtility.NativeMethodInfoPtr_GetHeightForLevelWithOffset_Public_Static_Single_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr, 100669781);
      TileLayerUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr, 100669782);
    }

    public TileLayerUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int CellBasedFlagCount
    {
      get
      {
        int cellBasedFlagCount;
        IL2CPP.il2cpp_field_static_get_value(TileLayerUtility.NativeFieldInfoPtr_CellBasedFlagCount, (void*) &cellBasedFlagCount);
        return cellBasedFlagCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileLayerUtility.NativeFieldInfoPtr_CellBasedFlagCount, (void*) &value);
      }
    }

    public static unsafe int StandardLayerFlagCount
    {
      get
      {
        int standardLayerFlagCount;
        IL2CPP.il2cpp_field_static_get_value(TileLayerUtility.NativeFieldInfoPtr_StandardLayerFlagCount, (void*) &standardLayerFlagCount);
        return standardLayerFlagCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileLayerUtility.NativeFieldInfoPtr_StandardLayerFlagCount, (void*) &value);
      }
    }

    public static unsafe int MapCollisionFlagCount
    {
      get
      {
        int collisionFlagCount;
        IL2CPP.il2cpp_field_static_get_value(TileLayerUtility.NativeFieldInfoPtr_MapCollisionFlagCount, (void*) &collisionFlagCount);
        return collisionFlagCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileLayerUtility.NativeFieldInfoPtr_MapCollisionFlagCount, (void*) &value);
      }
    }

    public static unsafe int LineOfSightFlagCount
    {
      get
      {
        int ofSightFlagCount;
        IL2CPP.il2cpp_field_static_get_value(TileLayerUtility.NativeFieldInfoPtr_LineOfSightFlagCount, (void*) &ofSightFlagCount);
        return ofSightFlagCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileLayerUtility.NativeFieldInfoPtr_LineOfSightFlagCount, (void*) &value);
      }
    }

    public static unsafe float HeightLevelOffset
    {
      get
      {
        float heightLevelOffset;
        IL2CPP.il2cpp_field_static_get_value(TileLayerUtility.NativeFieldInfoPtr_HeightLevelOffset, (void*) &heightLevelOffset);
        return heightLevelOffset;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileLayerUtility.NativeFieldInfoPtr_HeightLevelOffset, (void*) &value);
      }
    }

    public static unsafe byte MinHeightLevel
    {
      get
      {
        byte minHeightLevel;
        IL2CPP.il2cpp_field_static_get_value(TileLayerUtility.NativeFieldInfoPtr_MinHeightLevel, (void*) &minHeightLevel);
        return minHeightLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileLayerUtility.NativeFieldInfoPtr_MinHeightLevel, (void*) &value);
      }
    }

    public static unsafe byte MaxHeightLevel
    {
      get
      {
        byte maxHeightLevel;
        IL2CPP.il2cpp_field_static_get_value(TileLayerUtility.NativeFieldInfoPtr_MaxHeightLevel, (void*) &maxHeightLevel);
        return maxHeightLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileLayerUtility.NativeFieldInfoPtr_MaxHeightLevel, (void*) &value);
      }
    }

    public static unsafe byte HeightLevelRange
    {
      get
      {
        byte heightLevelRange;
        IL2CPP.il2cpp_field_static_get_value(TileLayerUtility.NativeFieldInfoPtr_HeightLevelRange, (void*) &heightLevelRange);
        return heightLevelRange;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileLayerUtility.NativeFieldInfoPtr_HeightLevelRange, (void*) &value);
      }
    }

    private sealed class MethodInfoStoreGeneric_AssertCorrectFlagCount_Private_Static_Void_Int32_0<TEnum>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileLayerUtility.NativeMethodInfoPtr_AssertCorrectFlagCount_Private_Static_Void_Int32_0, Il2CppClassPointerStore<TileLayerUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
      }))));
    }
  }
}
