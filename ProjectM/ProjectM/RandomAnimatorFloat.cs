// Decompiled with JetBrains decompiler
// Type: ProjectM.RandomAnimatorFloat
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class RandomAnimatorFloat : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_Frequency;
    private static readonly System.IntPtr NativeFieldInfoPtr_Layer;
    private static readonly System.IntPtr NativeFieldInfoPtr_LayerWeightThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr__Animator;
    private static readonly System.IntPtr NativeFieldInfoPtr__Time;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988593, XrefRangeEnd = 988597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RandomAnimatorFloat.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988597, XrefRangeEnd = 988605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RandomAnimatorFloat.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988605, XrefRangeEnd = 988606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RandomAnimatorFloat()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomAnimatorFloat>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RandomAnimatorFloat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RandomAnimatorFloat()
    {
      Il2CppClassPointerStore<RandomAnimatorFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RandomAnimatorFloat));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomAnimatorFloat>.NativeClassPtr);
      RandomAnimatorFloat.NativeFieldInfoPtr_MinMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomAnimatorFloat>.NativeClassPtr, nameof (MinMax));
      RandomAnimatorFloat.NativeFieldInfoPtr_Frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomAnimatorFloat>.NativeClassPtr, nameof (Frequency));
      RandomAnimatorFloat.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomAnimatorFloat>.NativeClassPtr, nameof (Layer));
      RandomAnimatorFloat.NativeFieldInfoPtr_LayerWeightThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomAnimatorFloat>.NativeClassPtr, nameof (LayerWeightThreshold));
      RandomAnimatorFloat.NativeFieldInfoPtr__Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomAnimatorFloat>.NativeClassPtr, nameof (_Animator));
      RandomAnimatorFloat.NativeFieldInfoPtr__Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomAnimatorFloat>.NativeClassPtr, nameof (_Time));
      RandomAnimatorFloat.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomAnimatorFloat>.NativeClassPtr, 100676259);
      RandomAnimatorFloat.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomAnimatorFloat>.NativeClassPtr, 100676260);
      RandomAnimatorFloat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomAnimatorFloat>.NativeClassPtr, 100676261);
    }

    public RandomAnimatorFloat(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector2 MinMax
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomAnimatorFloat.NativeFieldInfoPtr_MinMax));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomAnimatorFloat.NativeFieldInfoPtr_MinMax)) = value;
      }
    }

    public unsafe float Frequency
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomAnimatorFloat.NativeFieldInfoPtr_Frequency));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomAnimatorFloat.NativeFieldInfoPtr_Frequency)) = value;
      }
    }

    public unsafe int Layer
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomAnimatorFloat.NativeFieldInfoPtr_Layer));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomAnimatorFloat.NativeFieldInfoPtr_Layer)) = value;
      }
    }

    public unsafe float LayerWeightThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomAnimatorFloat.NativeFieldInfoPtr_LayerWeightThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomAnimatorFloat.NativeFieldInfoPtr_LayerWeightThreshold)) = value;
      }
    }

    public unsafe Animator _Animator
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomAnimatorFloat.NativeFieldInfoPtr__Animator));
        return pointer == System.IntPtr.Zero ? (Animator) null : new Animator(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RandomAnimatorFloat.NativeFieldInfoPtr__Animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _Time
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomAnimatorFloat.NativeFieldInfoPtr__Time));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomAnimatorFloat.NativeFieldInfoPtr__Time)) = value;
      }
    }

    public static class Hashes : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_float_randomOffset;

      static Hashes()
      {
        Il2CppClassPointerStore<RandomAnimatorFloat.Hashes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomAnimatorFloat>.NativeClassPtr, nameof (Hashes));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomAnimatorFloat.Hashes>.NativeClassPtr);
        RandomAnimatorFloat.Hashes.NativeFieldInfoPtr_float_randomOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomAnimatorFloat.Hashes>.NativeClassPtr, nameof (float_randomOffset));
      }

      public Hashes(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe int float_randomOffset
      {
        get
        {
          int floatRandomOffset;
          IL2CPP.il2cpp_field_static_get_value(RandomAnimatorFloat.Hashes.NativeFieldInfoPtr_float_randomOffset, (void*) &floatRandomOffset);
          return floatRandomOffset;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RandomAnimatorFloat.Hashes.NativeFieldInfoPtr_float_randomOffset, (void*) &value);
        }
      }
    }
  }
}
