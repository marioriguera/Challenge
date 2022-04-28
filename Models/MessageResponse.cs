using System;

namespace Challenge
{
    public class MessageResponse<T>
    {
        /** The success.*/
        public bool? Success { get; set; }
        /** The error*/
        public String? Error { get; set; }
        /** The message*/
        public T? Message { get; set; }

        /// <summary>
        /// Constructor vacío
        /// </summary>
        private MessageResponse() { }

        /// <summary>
        /// Para construir el mensaje cuando ocurre un error
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static MessageResponse<T> fail(String message)
        {
            MessageResponse<T> messageResponseDto = new MessageResponse<T>();
            messageResponseDto.Success = false;
            messageResponseDto.Error = message;
            messageResponseDto.Message = default(T);
            return messageResponseDto;
        }

        /// <summary>
        /// Para construir el mensaje cuando se devuelve correctamente un mensaje teniendo como parámetro
        /// un objeto
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static MessageResponse<T> success(T content)
        {
            MessageResponse<T> messageResponseDto = new MessageResponse<T>();
            messageResponseDto.Success = true;
            messageResponseDto.Error = null;
            messageResponseDto.Message = content;
            return messageResponseDto;
        }

        /// <summary>
        /// Para construir el mensaje cuando se devuelve correctamente un mensaje teniendo como parámetro
        /// un objeto de tipo MessageResponseDto
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static MessageResponse<T> success(MessageResponse<T> content)
        {
            MessageResponse<T> messageResponseDto = new MessageResponse<T>();
            messageResponseDto.Success = true;
            messageResponseDto.Error = null;
            messageResponseDto.Message = content.Message;
            return messageResponseDto;
        }

    }
}