// Decompiled with JetBrains decompiler
// Type: float3helper
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
public static class float3helper : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_up;
  private static readonly System.IntPtr NativeFieldInfoPtr_down;
  private static readonly System.IntPtr NativeFieldInfoPtr_right;
  private static readonly System.IntPtr NativeFieldInfoPtr_left;
  private static readonly System.IntPtr NativeFieldInfoPtr_forward;
  private static readonly System.IntPtr NativeFieldInfoPtr_backward;

  static float3helper()
  {
    Il2CppClassPointerStore<float3helper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (float3helper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<float3helper>.NativeClassPtr);
    float3helper.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3helper>.NativeClassPtr, nameof (up));
    float3helper.NativeFieldInfoPtr_down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3helper>.NativeClassPtr, nameof (down));
    float3helper.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3helper>.NativeClassPtr, nameof (right));
    float3helper.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3helper>.NativeClassPtr, nameof (left));
    float3helper.NativeFieldInfoPtr_forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3helper>.NativeClassPtr, nameof (forward));
    float3helper.NativeFieldInfoPtr_backward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3helper>.NativeClassPtr, nameof (backward));
  }

  public float3helper(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe float3 up
  {
    get
    {
      float3 up;
      IL2CPP.il2cpp_field_static_get_value(float3helper.NativeFieldInfoPtr_up, (void*) &up);
      return up;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(float3helper.NativeFieldInfoPtr_up, (void*) &value);
    }
  }

  public static unsafe float3 down
  {
    get
    {
      float3 down;
      IL2CPP.il2cpp_field_static_get_value(float3helper.NativeFieldInfoPtr_down, (void*) &down);
      return down;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(float3helper.NativeFieldInfoPtr_down, (void*) &value);
    }
  }

  public static unsafe float3 right
  {
    get
    {
      float3 right;
      IL2CPP.il2cpp_field_static_get_value(float3helper.NativeFieldInfoPtr_right, (void*) &right);
      return right;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(float3helper.NativeFieldInfoPtr_right, (void*) &value);
    }
  }

  public static unsafe float3 left
  {
    get
    {
      float3 left;
      IL2CPP.il2cpp_field_static_get_value(float3helper.NativeFieldInfoPtr_left, (void*) &left);
      return left;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(float3helper.NativeFieldInfoPtr_left, (void*) &value);
    }
  }

  public static unsafe float3 forward
  {
    get
    {
      float3 forward;
      IL2CPP.il2cpp_field_static_get_value(float3helper.NativeFieldInfoPtr_forward, (void*) &forward);
      return forward;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(float3helper.NativeFieldInfoPtr_forward, (void*) &value);
    }
  }

  public static unsafe float3 backward
  {
    get
    {
      float3 backward;
      IL2CPP.il2cpp_field_static_get_value(float3helper.NativeFieldInfoPtr_backward, (void*) &backward);
      return backward;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(float3helper.NativeFieldInfoPtr_backward, (void*) &value);
    }
  }
}
